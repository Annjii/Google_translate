using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Translate__Google.Utility;

namespace Translate_Google.BaseMethod
{
    public class WebSiteMethod
    {
        public static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver(@"C:\Users\mindc1may266\Downloads\chromedriver_win32");
            lognet.log.Info("InitializeDriver");
        }  
        public static void DriverClose()
        {
            driver.Close();
            lognet.log.Info("DriverClose");
        }

        public static void NavigateURL(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
          //  lognet.log.Info("NavigateURL");
        }
        public static void SelectElement(string elementpath)
        {
            IWebElement elementToCliicked = driver.FindElement(By.XPath(elementpath));
            elementToCliicked.Click();
            lognet.log.Info("SelectElement");
        }
        public static void ClickAndSendKeys(string elementpath, string words)
        {
            IWebElement elementToBeClicKed = driver.FindElement(By.XPath(elementpath));
            elementToBeClicKed.Click();
            elementToBeClicKed.SendKeys(words);
            lognet.log.Info("ClickAndSendKeys");
        }
    }
}
