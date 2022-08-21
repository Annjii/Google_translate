using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bookingflight_t.StepDefinitions
{
    [Binding]
    public class flightStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"open PHP login page")]
        public void GivenOpenPHPLoginPage()
        { 
            driver.Navigate().GoToUrl("https://www.phptravels.net/login");
        }

        [When(@"I enter the username")]
        public void WhenIEnterTheUsername()
        {
            driver.FindElement(By.XPath("*//input[@type='email']")).SendKeys("user@phptravels.com");


        }

        [When(@"I enter the password")]
        public void WhenIEnterThePassword()
        {
            driver.FindElement(By.XPath("*//input[@type='password']")).SendKeys("demouser");
        }

        [When(@"click on login")]
        public void WhenClickOnLogin()
        {
            driver.FindElement(By.XPath("*//button[@type='submit']")).Click();
        }

        [Then(@"the Dashboard page is displayed")]
        public void ThenTheDashboardPageIsDisplayed()
        {
            driver.FindElement(By.XPath("//*[@id='fadein']/div[1]/div/div[3]/ul/li[1]/a"));
        }
    }
}
