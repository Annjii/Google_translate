using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tide_com_Nuint.Utility;

namespace Tide_com_Nuint.DMethod
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
        }
        
    }
}
