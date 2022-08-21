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
    public class Login
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/login/");
            lognet.log.Info("NavigateURL");
        }
        public static void EnterEmail()
        {
            Thread.Sleep(2000);
            IWebElement loginn = method.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/div/div[2]/div/div[3]/div[2]/div/form/div[2]/div/input"));
            loginn.SendKeys("abcd0028@gmail.com");
            lognet.log.Info("EnterEmail");

        }
        public static void EnterPassword()
        {
            Thread.Sleep(2000);
            IWebElement loginn = method.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/div/div[2]/div/div[3]/div[2]/div/form/div[3]/div/input"));
            loginn.SendKeys("Abcd@1122");
            lognet.log.Info("EnterPassword");

        }
        public static void Loginn()
        {

            method.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/div/div[2]/div/div[3]/div[2]/div/form/div[5]/div[1]/input")).Click();
            lognet.log.Info("Loginn");
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("Loginn");
            lognet.log.Info("TakeSshottest");
        }
    }
}
