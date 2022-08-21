using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tide_com_Nuint.Utility;
using Tide_com_Nuint.DMethod;
using OpenQA.Selenium;

namespace Tide_com_Nuint.PageOMethod
{
    public class Selectloction
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1,1));
        }
        public static void ClickOnbutton()
        {

            Thread.Sleep(4000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div/div/div[2]/button")).Click();
        }
        public static void SelectLanguage()
        {
            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/a[2]")).Click();
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Selectaloction");
        }
    }
}
