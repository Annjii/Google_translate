using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunittest.basemethod
{
    public class Method
    {
        public static IWebDriver driver;
        public static void InitializeDriver()
        {
            driver = new ChromeDriver(@"C:\Users\mindc1may266\Downloads\chromedriver_win32");
        }
        public static void NavigateURL()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://tide.com/en-us");
        }
        public static void TearDown()
        {
            driver.Close();
        }
    }
}
