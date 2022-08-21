using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideNUnit.Utility;
using TideNUnit.DMethod;
using OpenQA.Selenium;
using System.Threading;

namespace TideNUnit.PageOMethod
{
    public class Selectloction
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1,1));
            lognet.log.Info("NavigateURL");
        }
        public static void ClickOnbutton()
        {

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div/div/div[2]/button")).Click();
            lognet.log.Info("ClickOnbutton");
        }
        public static void SelectLanguage()
        {
            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/a[2]")).Click();
            lognet.log.Info("SelectLanguage");
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Selectaloction");
            lognet.log.Info("TakeSshottest");
        }
    }
}
