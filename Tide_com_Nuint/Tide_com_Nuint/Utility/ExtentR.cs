using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Tide_com_Nuint.Utility
{
    public class ExtentR
    {
        public static ExtentReports extent;
        public static ExtentTest test;
       

        public static void generateReport()
        {
            var htmlRepoter = new ExtentHtmlReporter(@"C:\Users\mindc1may266\source\repos\Nunittest\Nunittest\Nunittest.html");
            htmlRepoter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlRepoter);

        }
        public static void flushReport()
        {
            extent.Flush();
        }
    }
}
