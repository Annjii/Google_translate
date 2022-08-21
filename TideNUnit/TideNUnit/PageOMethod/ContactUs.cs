using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TideNUnit.DMethod;
using TideNUnit.Utility;

namespace TideNUnit.PageOMethod
{
    public class ContactUs
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
            lognet.log.Info("NavigateURL");
        }
        public static void ClickOnButton()
        {
            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.CssSelector("#site-header > div.header-top-bar > div > div > div > div.header-top-bar-right-side.d-flex.align-items-center > a:nth-child(2)")).Click();
            lognet.log.Info("ClickOnButton");
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("ContactUs");
            lognet.log.Info("TakeSshottest");
        }
    }
}
