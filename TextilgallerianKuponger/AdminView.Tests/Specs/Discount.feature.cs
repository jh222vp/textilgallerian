﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AdminView.Tests.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AddNewDiscountCouponFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Discount.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add new discount coupon", "  In order to add a new discount coupon\r\n  As an editor\r\n  I want to be able to a" +
                    "dd a new discount coupon", ProgrammingLanguage.CSharp, new string[] {
                        "editor"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Add new discount coupon")))
            {
                AdminView.Tests.Specs.AddNewDiscountCouponFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add new percentage discount")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add new discount coupon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("editor")]
        public virtual void AddNewPercentageDiscount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new percentage discount", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("I am on the add new discount page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.And("I have selected the \"TotalSumPercentageDiscount\" in the discount type field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.And("I have entered \"Holiday Season\" in the \"Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.And("I have entered \"XMAS15\" in the \"Code\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.And("I have entered \"900105-3001\" in the \"CustomerString\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And("I have entered \"Test coupon\" in the \"Description\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
  testRunner.And("I have entered \"2015-04-15\" in the \"Start\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
  testRunner.And("I have entered \"2015-04-30\" in the \"End\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.And("I have entered \"2\" in the \"UseLimit\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
  testRunner.And("I have entered \"30\" in the \"Percentage\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
  testRunner.And("I have checked the coupon can be combined checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
     testRunner.When("I press \"Skapa rabatt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
     testRunner.Then("the system should present \"Rabatt sparad!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
  testRunner.And("a discount of type \"Köp för X:kr få Y:% rabatt\" should exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
  testRunner.And("it should have a \"Kampanjnamn\" of \"Holiday Season\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
  testRunner.And("it should have a \"Kampanjkod\" of \"XMAS15\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.And("it should have a \"Startdatum\" of \"2015-04-15\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
  testRunner.And("it should have a \"Slutdatum\" of \"2015-04-30\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add new amount discount")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add new discount coupon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("editor")]
        public virtual void AddNewAmountDiscount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new amount discount", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
    testRunner.Given("I am on the add new discount page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
  testRunner.And("I have selected the \"TotalSumAmountDiscount\" in the discount type field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
  testRunner.And("I have entered \"Easter Season\" in the \"Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.And("I have entered \"Chicken\" in the \"Code\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.And("I have entered \"900105-3001\" in the \"CustomerString\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
  testRunner.And("I have entered \"Test coupon\" in the \"Description\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
  testRunner.And("I have entered \"2015-04-01\" in the \"Start\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
  testRunner.And("I have entered \"2015-04-30\" in the \"End\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
  testRunner.And("I have entered \"2\" in the \"UseLimit\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
  testRunner.And("I have entered \"100\" in the \"Amount\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
     testRunner.When("I press \"Skapa rabatt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
     testRunner.Then("the system should present \"Rabatt sparad!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
  testRunner.And("a discount of type \"Köp för X:kr få Y:kr rabatt\" should exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
  testRunner.And("it should have a \"Kampanjnamn\" of \"Easter Season\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
  testRunner.And("it should have a \"Kampanjkod\" of \"Chicken\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
  testRunner.And("it should have a \"Startdatum\" of \"2015-04-01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
  testRunner.And("it should have a \"Slutdatum\" of \"2015-04-30\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add new percentage discount on purchase over x kr")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add new discount coupon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("editor")]
        public virtual void AddNewPercentageDiscountOnPurchaseOverXKr()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new percentage discount on purchase over x kr", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
    testRunner.Given("I am on the add new discount page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
  testRunner.And("I have selected the \"TotalSumPercentageDiscount\" in the discount type field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
  testRunner.And("I have entered \"Holiday Season\" in the \"Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
  testRunner.And("I have entered \"XMAS15\" in the \"Code\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
  testRunner.And("I have entered \"900105-3001\" in the \"CustomerString\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.And("I have entered \"Test coupon\" in the \"Description\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
  testRunner.And("I have entered \"2015-04-15\" in the \"Start\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
  testRunner.And("I have entered \"2015-04-30\" in the \"End\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
  testRunner.And("I have entered \"2\" in the \"UseLimit\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
  testRunner.And("I have entered \"30\" in the \"Percentage\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
  testRunner.And("I have entered \"500\" in the \"MinPurchase\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
  testRunner.And("I have checked the coupon can be combined checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
     testRunner.When("I press \"Skapa rabatt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
     testRunner.Then("the system should present \"Rabatt sparad!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
  testRunner.And("a discount of type \"Köp för X:kr få Y:% rabatt\" should exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
  testRunner.And("it should have a \"Kampanjnamn\" of \"Holiday Season\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
  testRunner.And("it should have a \"Kampanjkod\" of \"XMAS15\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
  testRunner.And("it should have a \"Startdatum\" of \"2015-04-15\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
  testRunner.And("it should have a \"Slutdatum\" of \"2015-04-30\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add new take Y pay for X discount")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add new discount coupon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("editor")]
        public virtual void AddNewTakeYPayForXDiscount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new take Y pay for X discount", ((string[])(null)));
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
    testRunner.Given("I am on the add new discount page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
  testRunner.And("I have selected the \"BuyXProductsPayForYProducts\" in the discount type field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
  testRunner.And("I have entered \"Summer\" in the \"Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
  testRunner.And("I have entered \"Beach\" in the \"Code\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
  testRunner.And("I have entered \"900105-3001\" in the \"CustomerString\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
  testRunner.And("I have entered \"Test coupon\" in the \"Description\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
  testRunner.And("I have entered \"2015-06-01\" in the \"Start\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
  testRunner.And("I have entered \"2015-08-30\" in the \"End\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
  testRunner.And("I have entered \"2\" in the \"UseLimit\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
  testRunner.And("I have entered \"3\" in the \"Buy\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
  testRunner.And("I have entered \"2\" in the \"PayFor\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
     testRunner.When("I press \"Skapa rabatt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
     testRunner.Then("the system should present \"Rabatt sparad!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
  testRunner.And("a discount of type \"Tag X betala för Y\" should exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
  testRunner.And("it should have a \"Kampanjnamn\" of \"Summer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
  testRunner.And("it should have a \"Kampanjkod\" of \"Beach\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
  testRunner.And("it should have a \"Startdatum\" of \"2015-06-01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
  testRunner.And("it should have a \"Slutdatum\" of \"2015-08-30\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add new buy product X and recieve product Y discount")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add new discount coupon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("editor")]
        public virtual void AddNewBuyProductXAndRecieveProductYDiscount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new buy product X and recieve product Y discount", ((string[])(null)));
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
    testRunner.Given("I am on the add new discount page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
  testRunner.And("I have selected the \"BuyProductXRecieveProductY\" in the discount type field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
  testRunner.And("I have entered \"Halloween\" in the \"Name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
  testRunner.And("I have entered \"pumpkin\" in the \"Code\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
  testRunner.And("I have entered \"900105-3001\" in the \"CustomerString\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
  testRunner.And("I have entered \"Test coupon\" in the \"Description\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
  testRunner.And("I have entered \"2015-09-01\" in the \"Start\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
  testRunner.And("I have entered \"2015-10-30\" in the \"End\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
  testRunner.And("I have entered \"Pink Curtain\" in the \"FreeProduct\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
  testRunner.And("I have entered \"2\" in the \"UseLimit\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
     testRunner.When("I press \"Skapa rabatt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
     testRunner.Then("the system should present \"Rabatt sparad!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
  testRunner.And("a discount of type \"Köp X få Y gratis\" should exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
  testRunner.And("it should have a \"Kampanjnamn\" of \"Halloween\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
  testRunner.And("it should have a \"Kampanjkod\" of \"pumpkin\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
  testRunner.And("it should have a \"Startdatum\" of \"2015-09-01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
  testRunner.And("it should have a \"Slutdatum\" of \"2015-10-30\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
