using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specflow.Global;

namespace Specflow.Common
{
    class Wait
    {
        public static void WebDriverWait(IWebDriver driver, int tineInSeconds,  string locatorvalue, string locatortype)
        {
            if (locatortype == "Id")
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(tineInSeconds));
                wait.Until(c => c.FindElement(By.Id(locatorvalue)));
                }
            if (locatortype == "Xpath")
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(tineInSeconds));
                wait.Until(c => c.FindElement(By.XPath(locatorvalue)));
            }

        }

    }
}
