using OpenQA.Selenium;
using TideNUnit.DMethod;
using TideNUnit.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TideNUnit.Utility
{
    public class Screenshoot
    {
        public static void TakeSshoot(String SShottest)
        {
            ((ITakesScreenshot)method.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may266\source\repos\TideNUnit\TideNUnit\Screenshoot\" + SShottest + ".Png");
        }
    }
}

