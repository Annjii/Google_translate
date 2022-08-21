using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Automation
{
    class Program
    {
        private const string V = "C:\Users\mindc1may266\Downloads";

        static void Main(string[] args)
        {
            chromeDriver chromeDriver = new chromeDriver(V);
            IWebDriver drive = (IWebDriver)chromeDriver;
            drive.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            IWebElement element = drive.FindElement(By.Id("idEample"));
            element.Click();

            Console.ReadLine();


        }
    }
}
