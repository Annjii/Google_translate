using OralBWebsiteAssignment.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OralBWebsiteAssignment.Pageofobjectmodel
{
    public class websitesMethod
    {

        public static IJavaScriptExecutor js;
        public void loadWebsite(string Url)
        {
            HookFile.driver.Manage().Window.Maximize();
            HookFile.driver.Navigate().GoToUrl(Url);
        }

        public void ClickOnElement(string ElementXPath)
        {
            Thread.Sleep(3000);
            HookFile.driver.FindElement(By.XPath(ElementXPath)).Click();
        }

        public void ScreenShot(string screenShotName)
        {
            ((ITakesScreenshot)HookFile.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may266\source\repos\OralBWebsiteAssignment\OralBWebsiteAssignment" + screenShotName + ".Png");
        }

        public void SearchInSearchBox(string battery)
        {
            Thread.Sleep(4000);
            IWebElement searchBox = HookFile.driver.FindElement(By.XPath("//*[@id='searchText']"));
            searchBox.SendKeys(battery);
            searchBox.SendKeys(Keys.Enter);
        }
        public void ScrollDownToElement(string ScrollDownElement)
        {
            js = (IJavaScriptExecutor)HookFile.driver;
            Thread.Sleep(2000);
            int locationY_OfElement = HookFile.driver.FindElement(By.XPath(ScrollDownElement)).Location.Y;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
        }

        public void VerifyText(string VerifyElementXPath)
        {
            Thread.Sleep(2000);
            string text = HookFile.driver.FindElement(By.XPath(VerifyElementXPath)).Text;
            if (text.Contains("FLOSS"))
            {
                Console.WriteLine("Text Present");
            }
            else if (text.Contains("BATTERY"))
            {
                Console.WriteLine("Text Present");
            }
            else if (text.Contains("KIDS"))
            {
                Console.WriteLine("Text Present");
            }
            else
            {
                Console.WriteLine("Text Not Present");
            }
        }
    }
}
