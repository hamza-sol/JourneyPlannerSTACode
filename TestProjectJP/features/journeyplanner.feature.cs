﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestProjectJP.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("journeyplanner")]
    public partial class JourneyplannerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "journeyplanner.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "features", "journeyplanner", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("JP01 - verify that a valid walking journey can be planned using widget")]
        public void JP01_VerifyThatAValidWalkingJourneyCanBePlannedUsingWidget()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("JP01 - verify that a valid walking journey can be planned using widget", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 testRunner.Given("customer is on tfl home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
 testRunner.When("customer enters \'Leicester Square\' in from field and selects to autocomplete the " +
                        "station name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 6
 testRunner.And("customer enters \'Covent Garden\' in to field and selects to autocomplete the stati" +
                        "on name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
 testRunner.And("customer selects to plan my journey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "walking speed",
                            "distance",
                            "duration"});
                table1.AddRow(new string[] {
                            "Moderate",
                            "0.4km",
                            "6mins"});
#line 8
 testRunner.Then("following information is displayed in the walking result of journey results:", ((string)(null)), table1, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("JP02 - verify that a valid cycling journey can be planned using widget")]
        public void JP02_VerifyThatAValidCyclingJourneyCanBePlannedUsingWidget()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("JP02 - verify that a valid cycling journey can be planned using widget", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
 testRunner.Given("customer is on tfl home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 14
 testRunner.When("customer enters \'Leicester Square\' in from field and selects to autocomplete the " +
                        "station name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.And("customer enters \'Covent Garden\' in to field and selects to autocomplete the stati" +
                        "on name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("customer selects to plan my journey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "route",
                            "distance",
                            "duration"});
                table2.AddRow(new string[] {
                            "Moderate",
                            "0.4km",
                            "1mins"});
#line 17
 testRunner.Then("following information is displayed in the cycling result of journey results:", ((string)(null)), table2, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("JP03 - validate the journey time for least walking route option")]
        public void JP03_ValidateTheJourneyTimeForLeastWalkingRouteOption()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("JP03 - validate the journey time for least walking route option", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 22
 testRunner.Given("customer is on journey result page for journey from \'Leicester Square\' to \'Covent" +
                        " Garden\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.When("customer selects to edit preference on journey result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.And("customer selects route with least walking option on journey result preferences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("customer selects update journey on journey result preferences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.Then("journey time is displayed on journey result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("JP04 - verify complete access information at covent garden underground station")]
        public void JP04_VerifyCompleteAccessInformationAtCoventGardenUndergroundStation()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("JP04 - verify complete access information at covent garden underground station", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 29
 testRunner.Given("customer is on journey result page for journey with least walking option from \'Le" +
                        "icester Square\' to \'Covent Garden\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 30
 testRunner.When("customer selects view details on first journey result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Access Information"});
                table3.AddRow(new string[] {
                            "Up stairs"});
                table3.AddRow(new string[] {
                            "Up lift"});
                table3.AddRow(new string[] {
                            "Level walkway"});
#line 31
 testRunner.Then("following access information is displayed for \'Covent Garden Underground Station\'" +
                        " on first result of journey result page:", ((string)(null)), table3, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("JP05 - verify journey planner provide invalid query when invalid locations are pr" +
            "ovided")]
        public void JP05_VerifyJourneyPlannerProvideInvalidQueryWhenInvalidLocationsAreProvided()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("JP05 - verify journey planner provide invalid query when invalid locations are pr" +
                    "ovided", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 38
 testRunner.Given("customer is on tfl home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
 testRunner.When("customer enters \'Leicester Square Underground Station\' in from field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.And("customer enters \'\'\'\' in to field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("customer selects to plan my journey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then("journey planner error message is displayed to customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("JP06 - verify journey planner widget shows required field message")]
        public void JP06_VerifyJourneyPlannerWidgetShowsRequiredFieldMessage()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("JP06 - verify journey planner widget shows required field message", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 45
 testRunner.Given("customer is on tfl home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 46
 testRunner.When("customer clicks on plan my journey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Error Message"});
                table4.AddRow(new string[] {
                            "The From field is required."});
                table4.AddRow(new string[] {
                            "The To field is required."});
#line 47
 testRunner.Then("following form errors are displayed to customer:", ((string)(null)), table4, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("JP07 - verify journey planner provide disambiguation results when incomplete loca" +
            "tions are provided")]
        public void JP07_VerifyJourneyPlannerProvideDisambiguationResultsWhenIncompleteLocationsAreProvided()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("JP07 - verify journey planner provide disambiguation results when incomplete loca" +
                    "tions are provided", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 52
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 53
 testRunner.Given("customer is on tfl home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 54
 testRunner.When("customer enters \'Leicester Square Underground Station\' in from field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.And("customer enters \'Rayners\' in to field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("customer selects to plan my journey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("disambiguation information page is displayed to customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion