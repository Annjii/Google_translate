using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    public class SearchBar
    {   
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1,1));
            lognet.log.Info("NavigateURL");
        }
        public static void ClickOnSearchBar()
        {

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[2]/div/div/div/form/div/input")).Click();
            lognet.log.Info("ClickOnSearchBar");

        }
        public static void EnterDataInSearchBar()
        {
           IWebElement SearchBar =  method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[2]/div/div/div/form/div/input"));
            SearchBar.SendKeys("Liquid");
            SearchBar.SendKeys(Keys.Enter);
            lognet.log.Info("EnterDataInSearchBar");
        }

        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Search Result");
            lognet.log.Info("TakeSshottest");
        }
    }
}
