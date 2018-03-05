using CT_Solution.TestExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using sample.TestExtension;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace sample
{
    [Binding]
    public class InvalidLogin_N_VerifySteps
    {
        //To inject WebDriver to make available for Test execution.
        private readonly IWebDriver _webDriver;
        ManageApplication mApp = new ManageApplication();
        ManageAppMethods appMethods = new ManageAppMethods();
        int default_wait_time = Convert.ToInt32(ConfigurationManager.AppSettings["Default_Wait_Time"]);
        string invalid_uname = ConfigurationManager.AppSettings["Invalid_UserName"];
        string invalid_pwrd = ConfigurationManager.AppSettings["Invalid_Password"];
        string application_url = ConfigurationManager.AppSettings["ApplicationUrl"];
        public InvalidLogin_N_VerifySteps(IWebDriver driver)
        {
            _webDriver = driver;
        }

        [Given(@"LoginPage is Active")]
        public void GivenLoginPageIsActive()
        {
            appMethods.LaunchApplication(_webDriver, application_url);
        }
        
        [When(@"Enter Invalid UserId and Password")]
        public void WhenEnterInvalidUserIdAndPassword()
        {
            mApp.EnterTextBoxValue(ManageObjects.LoginPage.UserName_EditBox(_webDriver), invalid_uname);
            mApp.EnterTextBoxValue(ManageObjects.LoginPage.Password_EditBox(_webDriver), invalid_pwrd);
            mApp.ClickElement(ManageObjects.LoginPage.Login_Button(_webDriver));
            System.Threading.Thread.Sleep(default_wait_time);
        }

        [Then(@"Warning message should be displayed")]
        public void ThenWarningMessageShouldBeDisplayed()
        {
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.LoginPage.InvalidLogin_WarningMessage(_webDriver)), "Warning message displyed");
        }

        [Then(@"LoginPage should Persist")]
        public void ThenLoginPageShouldPersist()
        {
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.LoginPage.UserName_EditBox(_webDriver)), "Login page Persists...");
        }
    }
}