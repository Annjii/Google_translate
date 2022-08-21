using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports.Gherkin.Model;
using Serilog;
using Serilog.Core;
using System;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;
using OralBWebsiteAssignment.Utilities;



namespace OralBWebsiteAssignment.Hooks
{
    [Binding]
    public class HookFile
    {
        public static IWebDriver driver;
      

        [BeforeTestRun]
        public static void GenerateReport()
        { 
            extentreport.InitializeReport();
            lognet.lognetfile();
        }

        [AfterTestRun]
        public static void closeExtentReport()
        {
            extentreport.flush();

        }

        [BeforeFeature]
        public static void featureBrowser(FeatureContext featureContext)
        {
            extentreport.featurefile();
            Log.Information("Selecting feature file {0} to run", featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void InitializeDriver(ScenarioContext scenarioContext)
        {
            driver = new ChromeDriver(@"C:\Users\mindc1may266\Downloads\chromedriver_win32");

            extentreport.scenarioflie();
            Log.Information("Selecting scenario {0} to run", scenarioContext.ScenarioInfo.Title);
        }
         
        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            extentreport.scenariosteps();
        }

        [AfterScenario]
        public static void CloseDriver()
        {
            driver.Close();
        }
    }
}