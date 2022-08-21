using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tide_com_Nuint.DMethod;
using Tide_com_Nuint.Utility;

namespace Tide_com_Nuint.PageOMethod
{
    public class ShopProducts
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1,1));
        }
        public static void ClickOnButton()
        {
            Thread.Sleep(4000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div/div[1]/a")).Click();
        }
        public static void SelectProducts()
        {
            Thread.Sleep(2000);          
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[4]/div/div/div/div[1]/div/div[1]/a/picture/img")).Click();
        }
        public static void ClickOnFindRetailers()
        {
            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[1]/div[1]/div[2]/div")).Click();
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Retailers");
        }
    }

}
