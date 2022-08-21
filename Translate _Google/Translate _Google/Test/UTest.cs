using Translate__Google.Utility;
using Translate__Google.Utility.Screenshot;
using Translate_Google.BaseMethod;
using Translate_Google.Utility;


namespace Translate_Google.Test
{
    public class Tests
    {
        [OneTimeSetUp]
        public void oneTimeSetUp()
        {
            ExtentReportna.generateReport();
            lognet.log.Info("Generate report");
        }
        [SetUp]
        public void Setup()
        {
            WebSiteMethod.InitializeDriver();
            lognet.log.Info("Initialize Driver");
        }
        [Test]
        public void Test1()
        {
            
            ExtentReportna.test = ExtentReportna.extent.CreateTest("Passing test");
            WebSiteMethod.NavigateURL("https://translate.google.com/");
            WebSiteMethod.ClickAndSendKeys("//*[@class='er8xn']","Typing");
            WebSiteMethod.SelectElement("/html/body/c-wiz/div/div[2]/c-wiz/div[2]/c-wiz/div[1]/div[1]/c-wiz/div[1]/c-wiz/div[5]/div/div[2]/div/div/span/button[2]");
            Thread.Sleep(6000);
            ScreenShoot.ScreenShot("translate");          
            lognet.log.Info("Navigate URL");
        }
        [Test]
        public void Test2()
        {
            ExtentReportna.test = ExtentReportna.extent.CreateTest("Passing test");
            WebSiteMethod.NavigateURL("https://translate.google.com/");
            WebSiteMethod.ClickAndSendKeys("//*[@class='er8xn']", "Hello");
            Thread.Sleep(5000);
            WebSiteMethod.SelectElement("/html/body/c-wiz/div/div[2]/c-wiz/div[2]/c-wiz/div[1]/div[1]/c-wiz/div[1]/c-wiz/div[5]/div/div[2]/div/div/span/button[3]/span[3]");
            Thread.Sleep(5000);
            ScreenShoot.ScreenShot("ARABIC");
            lognet.log.Info("translate Hello ARABIC");
           
        }
        [Test]
        public void Test3()
        {
            ExtentReportna.test = ExtentReportna.extent.CreateTest("Passing test");
            WebSiteMethod.NavigateURL("https://translate.google.com/");
            WebSiteMethod.ClickAndSendKeys("//*[@class='er8xn']", "Example");
            Thread.Sleep(5000);
             WebSiteMethod.SelectElement("/html/body/c-wiz/div/div[2]/c-wiz/div[2]/c-wiz/div[1]/div[1]/c-wiz/div[1]/c-wiz/div[5]/div/div[2]/div/div/span/button[2]");
            Thread.Sleep(5000);
            ScreenShoot.ScreenShot("AFRIKAANS");
            lognet.log.Info("translate Example AFRIKAANS");

        }
        [TearDown]
        public void TearDown()
        {
            WebSiteMethod.DriverClose();
            Thread.Sleep(2000);
            ExtentReportna.flushReport();
            lognet.log.Info("Driver Close");
        }
    }
}