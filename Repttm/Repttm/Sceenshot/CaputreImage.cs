using OpenQA.Selenium;
using Repttm.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repttm.Sceenshot
{
    class CaputreImage
    {
        public static void Cp(String SShottest)
        {
            ((ITakesScreenshot)DriverMethod.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may266\source\repos\Repttm\Repttm\Screenshoot\" + SShottest + ".Png");
        }
    }
}
