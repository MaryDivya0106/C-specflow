using OpenQA.Selenium;
using Specflow.Global;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow.Common
{
    class ExtenstionMethods
    {
        public static void userinputs(IWebDriver driver, String locatortype, String locatorvalue, String TextValue)
        {
            if(locatortype=="Xpath")
            {
                Driver.driver.FindElement(By.XPath(locatorvalue)).SendKeys(TextValue);
            }
            else if(locatortype=="id")
            {
                Driver.driver.FindElement(By.Id(locatorvalue)).SendKeys(TextValue);
            }

        }
        public static void ButtonClick(IWebDriver driver, String locatortype, String Locatorvalue)
        {
            if(locatortype=="Xpath")
            {
                Driver.driver.FindElement(By.XPath(Locatorvalue)).Click();
            }
            else if(locatortype=="id")
            {
                Driver.driver.FindElement(By.Id(Locatorvalue)).Click();
            }
        }
        
    }
}
