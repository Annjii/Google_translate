using OpenQA.Selenium;
using Tide_com_Nuint.DMethod;
using Tide_com_Nuint.Utility;

namespace Tide_com_Nuint.PageOMethod
{
    public class LiveChat
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1,1));
        }
        public static void ClickOnLiveChat()
        {

            Thread.Sleep(4000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div/div/div[2]/a[1]")).Click();
        }
        public static void ScrollToLiveChat()
        {
          //  method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/main/div/div/div/div/div[2]/ul")).Click();
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("LiveChat");
        }

    }
}