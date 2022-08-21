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
    public class What_sNew
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
            lognet.log.Info("NavigateURL");

        }
        public static void ClickOnWhat_sNewButton()
        {

            Thread.Sleep(2000);
             method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div/div[4]/a")).Click();
            lognet.log.Info("ClickOnWhat_sNewButton");
        }
   
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("What_sNew");
            lognet.log.Info("TakeSshottest");
        }
    }
}
