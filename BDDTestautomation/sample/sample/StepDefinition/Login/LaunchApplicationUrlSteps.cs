using CT_Solution.TestExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using sample.TestExtension;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace sample.StepDefinition.Login
{
    [Binding]
    public class LaunchApplicationUrlSteps
    {
        //To inject WebDriver to make available for Test execution.
        private readonly IWebDriver _webDriver;
        ManageApplication mApp = new ManageApplication();
        int default_wait_time = Convert.ToInt32(ConfigurationManager.AppSettings["Default_Wait_Time"]);

        string application_url = ConfigurationManager.AppSettings["ApplicationUrl"];
        public LaunchApplicationUrlSteps(IWebDriver driver)
        {
            _webDriver = driver;
        }

        [Given(@"Browser opened and active")]
        public void GivenBrowserOpenedAndActive()
        {
            Assert.IsTrue(_webDriver.CurrentWindowHandle != "", "Web Browser Launched..");
        }

        [When(@"I enter the Application Url")]
        public void WhenIEnterTheApplicationUrl()
        {
            _webDriver.Navigate().GoToUrl(application_url);
            mApp.WaitForAWhile(default_wait_time);
        }
        
        [Then(@"Application should Launch")]
        public void ThenApplicationShouldLaunch()
        {
            Console.WriteLine("..." + _webDriver.CurrentWindowHandle);
        }
        
        [Then(@"The EMail field should be displayed and enabled")]
        public void ThenTheEMailFieldShouldBeDisplayedAndEnabled()
        {
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.LoginPage.Password_EditBox(_webDriver)), "EMail Editbox field is diaplyed.");
        }
        
        [Then(@"The Password field should be displayed and enabled")]
        public void ThenThePasswordFieldShouldBeDisplayedAndEnabled()
        {
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.LoginPage.Password_EditBox(_webDriver)), "Password Editbox field is displayed.");
        }
        
        [Then(@"Login Button should be displayed N enabled")]
        public void ThenLoginButtonShouldBeDisplayedNEnabled()
        {
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.LoginPage.Login_Button(_webDriver)), "Login Button is enabled.");
        }
        
        [Then(@"Forget Password link should be displayed N enabled")]
        public void ThenForgetPasswordLinkShouldBeDisplayedNEnabled()
        {
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.LoginPage.ForgetPassword_Link(_webDriver)), "Forget Password Link is enabled.");
        }
    }
}
