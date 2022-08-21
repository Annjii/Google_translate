using OpenQA.Selenium;
using Repttm.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Repttm.POM
{
    class LoadWebsites
    {
        public static void GoToUrl()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl("https://www.trivago.com/");
        }
        public static void  CarOption()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//span[contains(text(),'Cars')]")).Click();
        }
        public static void samedropoff()
        {
            DriverMethod.driver.FindElement(By.XPath("//span[contains(text(),'Same drop-off')]")).Click();
        }
        public static void Enterfrom()
        {
            DriverMethod.driver.FindElement(By.XPath("//input[@type='text']")).Click();
        }
        public static void airportfromdropdown()
        {
           // DriverMethod.driver.FindElement(By.XPath("")).Click();
        }
    }
}
