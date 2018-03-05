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
    public class LogOut_N_VerifySteps
    {
        //To inject WebDriver to make available for Test execution.
        private readonly IWebDriver _webDriver;
        ManageApplication mApp = new ManageApplication();
        int default_wait_time = Convert.ToInt32(ConfigurationManager.AppSettings["Default_Wait_Time"]);

        string valid_uname = ConfigurationManager.AppSettings["UserName"];
        string valid_pwrd = ConfigurationManager.AppSettings["Password"];

        string application_url = ConfigurationManager.AppSettings["ApplicationUrl"];
        public LogOut_N_VerifySteps(IWebDriver driver)
        {
            _webDriver = driver;
        }

        [Given(@"User Authenticated Successfilly")]
        public void GivenUserAuthenticatedSuccessfilly()
        {
            mApp.EnterTextBoxValue(ManageObjects.LoginPage.UserName_EditBox(_webDriver), valid_uname);
            mApp.EnterTextBoxValue(ManageObjects.LoginPage.Password_EditBox(_webDriver), valid_pwrd);
            mApp.ClickElement(ManageObjects.LoginPage.Login_Button(_webDriver));
            System.Threading.Thread.Sleep(default_wait_time);
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.AccountOverviewPage.EditAccountInfo_Button(_webDriver)), "Account Overview page exists..");
        }

        [When(@"I Click SignOut link")]
        public void WhenIClickSignOutLink()
        {
            mApp.ClickElement(ManageObjects.LoginPage.SignOut_Link(_webDriver));
            System.Threading.Thread.Sleep(default_wait_time);
        }

        [Then(@"User should logout successfully")]
        public void ThenUserShouldLogoutSuccessfully()
        {
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.LoginPage.SignInBack_Button(_webDriver)));
        }
    }
}
