using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTEST
{
    public class Tests
    {
        private object SigninTextField;

        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
            String title = driver.Title;

            driver.Url = "https://www.google.com/intl/en-GB/gmail/about/";
            IWebElement emailTextField = driver.FindElement(By.XPath(//*[@id="_iwa0YuD_NIb50ATKzJ2wBA1"]));
            SigninTextField.SendKeys("Selenium c#");
            driver.Close();
            driver.Quit();
        }


        
    }
}