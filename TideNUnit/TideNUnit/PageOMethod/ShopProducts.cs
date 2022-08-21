using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TideNUnit.DMethod;
using TideNUnit.Utility;

namespace TideNUnit.PageOMethod
{
    public class ShopProducts
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1,1));
            lognet.log.Info("NavigateURL");
        }
        public static void ClickOnButton()
        {
            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[3]/div/div/div/div[1]/a")).Click();
            lognet.log.Info("ClickOnButton");
        }
        public static void SelectProducts()
        {
            Thread.Sleep(2000);          
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[4]/div/div/div/div[1]/div/div[1]/a/picture/img")).Click();
            lognet.log.Info("SelectProducts");
        }
        public static void ClickOnFindRetailers()
        {
            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[1]/div[1]/div[2]/div")).Click();
            lognet.log.Info("ClickOnFindRetailers");
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Retailers");
            lognet.log.Info("TakeSshottest");
        }
    }

}
