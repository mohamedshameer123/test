﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Selenium.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class LoremIpsumFeature : Xunit.IClassFixture<LoremIpsumFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "LoremIpsum.feature"
#line hidden
        
        public LoremIpsumFeature(LoremIpsumFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Lorem Ipsum", "\t\tAs a User,\n\t\tI can generate variations of Lorem Ipsum text", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Paragraphs - Generate with starting text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Paragraphs - Generate with starting text")]
        public virtual void Paragraphs_GenerateWithStartingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Paragraphs - Generate with starting text", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Amount",
                        "Text Generation Type",
                        "Start With Default Text"});
            table1.AddRow(new string[] {
                        "5",
                        "Paras",
                        "True"});
#line 8
 testRunner.When("I generate text with default starting text", ((string)(null)), table1, "When ");
#line 11
 testRunner.Then("the paragraphs are generated correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Paragraphs - Generate without starting text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Paragraphs - Generate without starting text")]
        public virtual void Paragraphs_GenerateWithoutStartingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Paragraphs - Generate without starting text", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Amount",
                        "Text Generation Type",
                        "Start With Default Text"});
            table2.AddRow(new string[] {
                        "5",
                        "Paras",
                        "False"});
#line 15
 testRunner.When("I generate text without default starting text", ((string)(null)), table2, "When ");
#line 18
 testRunner.Then("the paragraphs are generated correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Words - Generate with starting text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Words - Generate with starting text")]
        public virtual void Words_GenerateWithStartingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Words - Generate with starting text", null, ((string[])(null)));
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Amount",
                        "Text Generation Type",
                        "Start With Default Text"});
            table3.AddRow(new string[] {
                        "5",
                        "Words",
                        "True"});
#line 22
 testRunner.When("I generate text with default starting text", ((string)(null)), table3, "When ");
#line 25
 testRunner.Then("the words are generated correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Words - Generate without starting text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Words - Generate without starting text")]
        public virtual void Words_GenerateWithoutStartingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Words - Generate without starting text", null, ((string[])(null)));
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Amount",
                        "Text Generation Type",
                        "Start With Default Text"});
            table4.AddRow(new string[] {
                        "5",
                        "Words",
                        "False"});
#line 29
 testRunner.When("I generate text without default starting text", ((string)(null)), table4, "When ");
#line 32
 testRunner.Then("the words are generated correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Bytes - Generating less than 28 bytes of text is exact match with default text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Bytes - Generating less than 28 bytes of text is exact match with default text")]
        [Xunit.InlineDataAttribute("0", "27", "true", new string[0])]
        [Xunit.InlineDataAttribute("14", "27", "true", new string[0])]
        [Xunit.InlineDataAttribute("27", "27", "true", new string[0])]
        [Xunit.InlineDataAttribute("28", "28", "false", new string[0])]
        public virtual void Bytes_GeneratingLessThan28BytesOfTextIsExactMatchWithDefaultText(string amount, string expectedAmount, string value, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bytes - Generating less than 28 bytes of text is exact match with default text", null, exampleTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.When(string.Format("I generate {0} bytes of text with default starting text", amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then(string.Format("{0} bytes of text generates and \"Lorem ipsum dolor sit amet.\" exact match is {1}", expectedAmount, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Lists - Generate single list with starting text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Lists - Generate single list with starting text")]
        public virtual void Lists_GenerateSingleListWithStartingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lists - Generate single list with starting text", null, ((string[])(null)));
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 48
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.When("I generate \"1\" list with default starting text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("the list generates correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Lists - Generate single list without starting text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Lists - Generate single list without starting text")]
        public virtual void Lists_GenerateSingleListWithoutStartingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lists - Generate single list without starting text", null, ((string[])(null)));
#line 52
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 53
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 54
 testRunner.When("I generate \"1\" list without default starting text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("the list generates correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Lists - Generate multiple lists with starting text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Lists - Generate multiple lists with starting text")]
        public virtual void Lists_GenerateMultipleListsWithStartingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lists - Generate multiple lists with starting text", null, ((string[])(null)));
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.When("I generate \"8\" lists with default starting text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("the list generates correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Lists - Generate multiple lists without starting text")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "Lists - Generate multiple lists without starting text")]
        public virtual void Lists_GenerateMultipleListsWithoutStartingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lists - Generate multiple lists without starting text", null, ((string[])(null)));
#line 62
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 63
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.When("I generate \"8\" lists without default starting text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("the list generates correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="DocString - This is a Doc String")]
        [Xunit.TraitAttribute("FeatureTitle", "Lorem Ipsum")]
        [Xunit.TraitAttribute("Description", "DocString - This is a Doc String")]
        public virtual void DocString_ThisIsADocString()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DocString - This is a Doc String", null, ((string[])(null)));
#line 67
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 68
 testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
 testRunner.When("I generate text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("I am presented with", "Stuff is generated", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                LoremIpsumFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                LoremIpsumFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
