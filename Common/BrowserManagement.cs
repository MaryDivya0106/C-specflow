using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specflow.resourcefile;
using Specflow.Global;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Specflow.Common
{
    class BrowserManagement
    {
        public static IWebDriver localdriver = Driver.driver;
        public static string Browser= Resource1.Browser;
        public static void BrowserAction()
        {
            if (Browser == "Chrome")
            {

                Driver.driver = new ChromeDriver();
            }
            else if (Browser == "Firefox")
            {
                Driver.driver = new FirefoxDriver();
            }
            
           
        }
        public static void UrlAction()
        {
            Driver.driver.Navigate().GoToUrl(Resource1.Url);
        }
        
    }
}
