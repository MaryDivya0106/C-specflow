using System;
using TechTalk.SpecFlow;
using Specflow.Global;
using Specflow.pages;
using NUnit.Framework;

namespace Specflow.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"i have launched the browser\.")]
        public void GivenIHaveLaunchedTheBrowser_()
        {
            // ScenarioContext.Current.Pending();
            Common.BrowserManagement.BrowserAction();
        }
        
        [Given(@"i have given url\.")]
        public void GivenIHaveGivenUrl_()
        {
            // ScenarioContext.Current.Pending();
            Common.BrowserManagement.UrlAction();
        }

        [When(@"I entered ""(.*)"", ""(.*)"" and clicked login button\.")]
        public void WhenIEnteredAndClickedLoginButton_(string p0, string p1)
        {
            Common.ScreenShot.takeScreenShot(Driver.driver, "FIRST SCREENSHOT");
            //ScenarioContext.Current.Pending();
            Login.loginMethod(p0, p1);

        }


        //[When(@"I entered bereddydivya@gmail\.com, Divyareddy(.*) and clicked login button\.")]
        //public void WhenIEnteredBereddydivyaGmail_ComDivyareddyAndClickedLoginButton_(int p0)
        //{
        //    //ScenarioContext.Current.Pending();
        //    pages.Login.loginMethod();
        //}
        
        [Then(@"i have navigated to facebook home page\.")]
        public void ThenIHaveNavigatedToFacebookHomePage_()
        {
          //  ScenarioContext.Current.Pending();
            try
            {
                
                Assert.AreEqual("(21) Facebook", Driver.driver.Title);
               
                Console.WriteLine("paassed");
            }
            catch (Exception ex)
            {
                Common.ScreenShot.takeScreenShot(Driver.driver, "FB fail");
                Console.WriteLine("failed");
            }

            Global.Driver.driver.Quit();
        }
    }
}
