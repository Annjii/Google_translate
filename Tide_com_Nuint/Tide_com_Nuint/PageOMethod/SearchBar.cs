using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tide_com_Nuint.DMethod;
using Tide_com_Nuint.Utility;

namespace Tide_com_Nuint.PageOMethod
{
    public class SearchBar
    {   
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1,1));
        }
        public static void ClickOnSearchBar()
        {

            Thread.Sleep(4000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[2]/div/div/div/form/div/input")).Click();

        }
        public static void EnterDataInSearchBar()
        {
           IWebElement SearchBar =  method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[2]/div/div/div/form/div/input"));
            SearchBar.SendKeys("Liquid");
            SearchBar.SendKeys(Keys.Enter);
        }

        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Search Result");
        }
    }
}
