using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Specflow.Global;

namespace Specflow.Common
{
    class ScreenShot
    {
        public static void takeScreenShot(IWebDriver driver, String Filename)
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("C:/Users/divya/source/repos/Specflow"+Filename+"Png");

        }
    }
}
