using OpenQA.Selenium;
using System.Threading;
using TideNUnit.DMethod;
using TideNUnit.Utility;

namespace TideNUnit.PageOMethod
{
    public class LiveChat
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1,1));
            lognet.log.Info("NavigateURL");
        }
        public static void ClickOnLiveChat()
        {

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div/div/div[2]/a[1]")).Click();
            lognet.log.Info("ClickOnLiveChat");
        }
        public static void ScrollToLiveChat()
        {
            //   method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div/div/div/div/div[2]/ul")).Click();
            //lognet.log.Info("ScrollToLiveChat");
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("LiveChat");
            lognet.log.Info("TakeSshottest");
        }

    }
}