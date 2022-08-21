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

namespace OralBWebsiteAssignment.Utilities
{
    public class lognet
    {
        public static void lognetfile()
        {
            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch: loggingLevel).WriteTo.File(
            @"C:\Users\mindc1may266\source\repos\OralBWebsiteAssignment\OralBWebsiteAssignment\Utilities\log.log",outputTemplate: "{TimeSpan:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message}{NewLine}",
             rollingInterval: RollingInterval.Day).CreateLogger();
        }
      
    }
    
}
