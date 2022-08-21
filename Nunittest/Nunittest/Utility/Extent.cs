using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Nunittest.Utility
{
    public class Extent
    {
            public static ExtentReports extent;
            public static ExtentTest test;

            public static void generateReport()
            {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\mindc1may266\source\repos\Nunittest\Nunittest\Nunittest.html");
                htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);

            }
            public static void flushReport()
            {
                extent.Flush();
            }       
    }
}
