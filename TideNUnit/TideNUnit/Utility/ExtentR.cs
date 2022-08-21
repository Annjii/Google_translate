using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace TideNUnit.Utility
{
    public class ExtentR
    {
        public static ExtentReports extent;
        public static ExtentTest test;
       

        public static void generateReport()
        {
            var htmlRepoter = new ExtentHtmlReporter("C:\\Users\\mindc1may266\\source\\repos\\TideNUnit\\TideNUnit\\Index.html");
            htmlRepoter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlRepoter);
            lognet.log.Info("generateReport");

        }
        public static void flushReport()
        {
            extent.Flush();
            lognet.log.Info("flushReport");
        }
    }
}
