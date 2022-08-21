using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Tide_com_Nuint.DMethod;
using Tide_com_Nuint.Utility;


namespace Tide_com_Nuint.PageOMethod
{
    public class Register
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
        }
        public static void ClickOnButton()
        {
            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[1]/div/div/div/div[2]/span/a")).Click();
        }
        public static void ClickontheSignup()
        {
            
            method.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[1]/div/div/div/div[2]/div/p[6]/a")).Click();
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Signup");
        }
    }
}
