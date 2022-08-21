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
    public class Register
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
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[1]/div/div/div/div[2]/span/a")).Click();
            lognet.log.Info("ClickOnButton");
        }
        public static void ClickontheSignup()
        {

            Thread.Sleep(3000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[1]/div/div/div/div[2]/div/p[6]/a")).Click();
            lognet.log.Info("ClickontheSignup");
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Signup");
            lognet.log.Info("NavigateURL");
        }
    }
}
