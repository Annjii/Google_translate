using OpenQA.Selenium;
using Tide_com_Nuint.DMethod;
using Tide_com_Nuint.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tide_com_Nuint.Utility
{
    public class Screenshoot
    {
        public static void TakeSshoot(String SShottest)
        {
            ((ITakesScreenshot)method.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may266\source\repos\Tide_com_Nuint\Tide_com_Nuint\Screenshoot\" + SShottest + ".Png");
        }
    }
}

