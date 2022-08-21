using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translate_Google.BaseMethod;

namespace Translate__Google.Utility.Screenshot
{
    public class ScreenShoot
    {
        public static void ScreenShot(string SShottest)
        {
            ((ITakesScreenshot)WebSiteMethod.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may266\source\repos\Translate _Google\Translate _Google\Utility\Screenshot\" + SShottest + ".Png");
        }
    }
}
