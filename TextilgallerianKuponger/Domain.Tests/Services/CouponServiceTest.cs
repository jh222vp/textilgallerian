﻿using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services;
using Domain.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSpec;

namespace Domain.Tests.Services
{
    [TestClass]
    public class CouponServiceTest
    {
        private Cart _cart;
        private CouponService _couponService;
        private Product _freeProduct;
        private Customer _invalidCustomer;
        private Product _invalidProduct;
        private RepositoryFactory _repositoryFactory;
        private Customer _validCustomer;
        private CouponRepository _couponRepository;

        /// <summary>
        ///     Setup our configuration and conventions for all of our tests
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            _repositoryFactory = new RepositoryFactory();

            _couponRepository = _repositoryFactory.Get();

            _couponService = new CouponService(_couponRepository);

            _freeProduct = Testdata.RandomProduct();
            _invalidProduct = Testdata.RandomProduct();
            _validCustomer = Testdata.RandomCustomer();
            _invalidCustomer = Testdata.RandomCustomer();
            _cart = Testdata.EmptyCart();
            _cart.Customer = Testdata.RandomCustomer();
            _cart.Rows.Add(new Row
            {
                Amount = 3,
                Product = Testdata.RandomProduct(),
                ProductPrice = 50
            });

            _couponRepository.Store(Testdata.RandomCoupon(new ValidCoupon
            {
                Code = "Valid Code"
            }, true));
            _couponRepository.Store(Testdata.RandomCoupon(new ValidCoupon
            {
                Name = "Valid Code with customer",
                CustomersValidFor = new List<Customer> {_validCustomer}
            }, true));
            _couponRepository.Store(Testdata.RandomCoupon(new InvalidCoupon
            {
                Name = "Valid Coupon"
            }, true));
            _couponRepository.Store(Testdata.RandomCoupon(new InvalidCoupon
            {
                CustomersValidFor = new List<Customer> {_validCustomer}
            }, true));

            _couponRepository.Store(Testdata.RandomCoupon(new BuyProductXRecieveProductY
            {
                Name = "free product",
                CustomersValidFor = new List<Customer>
                {
                    _cart.Customer,
                    new Customer { CouponCode = "CustomerCode" }
                },
                Products = new List<Product> {_cart.Rows.First().Product},
                NumberOfProductsToBuy = 1,
                FreeProduct = _freeProduct,
                Start = DateTime.Now,
                UseLimit = 1000
            }, true));
            _couponRepository.Store(Testdata.RandomCoupon(new BuyProductXRecieveProductY
            {
                Name = "Free but uncombineable product",
                CustomersValidFor = new List<Customer> {_cart.Customer},
                Products = new List<Product> {_cart.Rows.First().Product},
                NumberOfProductsToBuy = 1,
                FreeProduct = _invalidProduct,
                Start = DateTime.Now,
                UseLimit = 1000,
                IsActive = true
            }, false));
            _couponRepository.Store(Testdata.RandomCoupon(new TotalSumPercentageDiscount
            {
                UniqueKey = "percentage",
                Name = "20%",
                CustomersValidFor = new List<Customer> {_cart.Customer},
                Percentage = 0.2m,
                Start = DateTime.Now,
                UseLimit = 1000,
                DiscountOnlyOnSpecifiedProducts = true,
            },
            true));
            _couponRepository.Store(Testdata.RandomCoupon(new BuyXProductsPayForYProducts
            {
                Code = "3 for 2",
                Products = new List<Product> {_cart.Rows.First().Product},
                NumberOfProductsToBuy = 3,
                PayFor = 2,
                Start = DateTime.Now,
                UseLimit = 1000
            }, false, true));

            _couponRepository.SaveChanges();
        }

        [TestCleanup]
        public void TearDown()
        {
            _repositoryFactory.Dispose();
        }

        [TestMethod]
        public void TestThatItCanFindCouponsByProvidedCode()
        {
            var cart = Testdata.RandomCart("Valid Code");

            var result = _couponService.FindBestCouponsForCart(cart).Discounts;

            result.Count.should_be(1);
            result[0].Code.should_be("Valid Code");
        }

        [TestMethod]
        public void TestThatItCanFindCouponsByProvidedCodeOnCustomers()
        {
            var cart = Testdata.RandomCart("CustomerCode");

            cart.Rows.Add(_cart.Rows.First());

            var result = _couponService.FindBestCouponsForCart(cart).Discounts;

            result.Count.should_be(1);
            result[0].Name.should_be("free product");
        }

        [TestMethod]
        public void TestThatItCanNotFindCouponsByInvalidProvidedCode()
        {
            var cart = Testdata.RandomCart("Invalid Code");

            var result = _couponService.FindBestCouponsForCart(cart).Discounts;

            result.Count.should_be(0);
        }

        [TestMethod]
        public void TestThatItCanFindCouponsByCustomerEmail()
        {
            var cart = Testdata.RandomCart(customerCheckingOut: Testdata.RandomCustomer(_validCustomer.Email));

            var result = _couponService.FindBestCouponsForCart(cart).Discounts;

            // Only one becouse the other coupon is invalid
            result.Count.should_be(1);
        }

        [TestMethod]
        public void TestThatItCanNotFindCouponsByInvalidCustomerEmail()
        {
            var cart = Testdata.RandomCart(customerCheckingOut: Testdata.RandomCustomer(_invalidCustomer.Email));

            var result = _couponService.FindBestCouponsForCart(cart).Discounts;

            result.Count.should_be(0);
        }

        [TestMethod]
        public void TestThatItCanFindCouponsByCustomerSsn()
        {
            var cart =
                Testdata.RandomCart(
                    customerCheckingOut:
                        Testdata.RandomCustomer(socialSecurityNumber: _validCustomer.SocialSecurityNumber));

            var result = _couponService.FindBestCouponsForCart(cart).Discounts;

            // Only one becouse the other coupon is invalid
            result.Count.should_be(1);
        }

        [TestMethod]
        public void TestThatItCanNotFindCouponsByInvalidCustomerSsn()
        {
            var cart =
                Testdata.RandomCart(
                    customerCheckingOut:
                        Testdata.RandomCustomer(socialSecurityNumber: _invalidCustomer.SocialSecurityNumber));

            var result = _couponService.FindBestCouponsForCart(cart).Discounts;

            result.Count.should_be(0);
        }

        [TestMethod]
        public void TestThatItDoesNotCollectTheSameDiscountMultipleTimes()
        {
            var cart = Testdata.RandomCart("Valid Code with customer", _validCustomer);

            var result = _couponService.FindBestCouponsForCart(cart).Discounts;

            // Only one becouse the other coupon is invalid
            result.Count.should_be(1);
        }

        [TestMethod]
        public void TestThatTheBestOfferIsPickedIfProductsIsNull()
        {
            var coupon = _couponRepository.FindByUniqueKey("percentage");
            coupon.Products = null;
            _couponRepository.Store(coupon);
            _couponRepository.SaveChanges();

            var result = _couponService.FindBestCouponsForCart(_cart);

            // We only want 2 discounts and 2 rows as the other "free product" coupon isn't combinable
            result.Discounts.Count.should_be(2);
            result.Discounts[0].Name.should_be("free product");
            result.Discounts[1].Name.should_be("20%");
            result.Rows.Count.should_be(2);
            result.Rows[1].Product.should_be(_freeProduct);
        }


        [TestMethod]
        public void TestThatTheBestOfferIsPickedIfProductsIsPresent()
        {
            var result = _couponService.FindBestCouponsForCart(_cart);

            // We only want 2 discounts and 2 rows as the other "free product" coupon isn't combinable
            result.Discounts.Count.should_be(1);
            result.Discounts[0].Name.should_be("Free but uncombineable product");
            result.Rows.Count.should_be(2);
            result.Rows[1].Product.should_be(_invalidProduct);
        }

        [TestMethod]
        public void TestThatTheBestOfferIsPickedIfProductsIsPresentButCouponCalculatesOnAll()
        {
            var coupon = _couponRepository.FindByUniqueKey("percentage") as TotalSumPercentageDiscount;
            coupon.DiscountOnlyOnSpecifiedProducts = false;
            _couponRepository.Store(coupon);
            _couponRepository.SaveChanges();

            _cart.Rows.Add(
                new Row
                {
                    Product = coupon.Products.Last()
                }
                
            );

            var result = _couponService.FindBestCouponsForCart(_cart);

            // We only want 2 discounts and 2 rows as the other "free product" coupon isn't combinable
            result.Discounts.Count.should_be(2);
            result.Discounts[0].Name.should_be("free product");
            result.Discounts[1].Name.should_be("20%");
            result.Rows.Count.should_be(3);
            result.Rows[2].Product.should_be(_freeProduct);
        }

        [TestMethod]
        public void TestThatTheBestOfferIsPickedWithCode()
        {
            _cart.CouponCode = "3 for 2";
            var result = _couponService.FindBestCouponsForCart(_cart);

            result.Discounts.Count.should_be(1);
            result.Discounts[0].Code.should_be("3 for 2");
            result.Rows.Count.should_be(1);
        }
    }
}