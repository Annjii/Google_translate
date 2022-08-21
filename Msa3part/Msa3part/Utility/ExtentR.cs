using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msa3part.Utility
{
   
    public class ExtentR
    {
        public static ExtentReports Extent;
        public static ExtentTest test;

        public static void generateReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\mindc1may266\source\repos\Msa3part\Msa3part\Index.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            Extent = new ExtentReports();
            Extent.AttachReporter(htmlReporter);

        }
        public static void flushReport()
        {
            Extent.Flush(); 
        }
    }
}
