using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp11
{
    class Program
    {
        private object element;
        private object driver;

        static void Main(string[] args)
        {          
        }
        public void Initialize()
        {
            object p = driver.Navigate().GoToUrl("https://www.google.com");
        }

        public void ExecuteTest()
        {
            IWebDriver driver = new ChromeDriver("q");
            object p = element.sendkeys("excuteautomation");
           
        }
    }
}
    //Console.WriteLine("Hello World!");