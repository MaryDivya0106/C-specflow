using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Specflow.Common;
using Specflow.Global;
using Specflow.resourcefile;

namespace Specflow.pages
{
    class Login
    {
      // public static IWebDriver localdriver = BrowserManagement.localdriver;
        public static void loginMethod(string username, string password)
        {
          
            ExtenstionMethods.userinputs(Driver.driver, "Xpath", "//input[@class='inputtext']", username);
            ExtenstionMethods.userinputs(Driver.driver, "id", "pass", password);
            
            ExtenstionMethods.ButtonClick(Driver.driver, "Xpath", "//label[@id='loginbutton']/input");
            Driver.driver.Navigate().Back();
        }
    }
}
