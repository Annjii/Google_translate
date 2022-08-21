using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideNUnit.Utility;

namespace TideNUnit.DMethod
{
  
    public class method
    {
        public static IWebDriver driver;
        public static void InitializeDriver()
        {
            driver = new ChromeDriver(@"C:\Users\mindc1may266\Downloads\chromedriver_win32");

            lognet.log.Info("InitializeDriver");
            
        }
        public static void CloseDriver()
        {
            
            driver.Close();
            lognet.log.Info("CloseDriver");
        }
        
    }
}
