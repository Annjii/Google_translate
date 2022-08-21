using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace book_test
{
    class Program
    {   
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\mindc1may266\\Downloads\\chromedriver_win32");
            driver.Manage().Window.Maximize();
            driver.Url = "https://indianbookworms.com/";
            driver.FindElement(By.XPath("//*[@id='__layout']/div/div/div[2]/div/form/div/input[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='searchinput']")).SendKeys("Ocean");
            driver.FindElement(By.XPath("//*[@id='searchinput']")).SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("#__layout > div > div > div.block.relative.px-4 > div > div:nth-child(4) > a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.CssSelector("#__layout > div > div > div.grid.grid-cols-1.md\\:grid-cols-12.gap-10.relative.px-4 > div.col-span-full.md\\:col-span-8.xl\\:col-span-10 > div.block.relative.max-w-5xl > div.block.mt-8.mb-2 > a:nth-child(8) > span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Console.WriteLine(driver.FindElement(By.CssSelector("#Details > div > div > table > tbody > tr:nth-child(6) > td:nth-child(2) > span")).Text);

        }
    }
}
