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
    public class Varify_ValidLoginSteps
    {
        //To inject WebDriver to make available for Test execution.
        private readonly IWebDriver _webDriver;
        ManageApplication mApp = new ManageApplication();
        int default_wait_time = Convert.ToInt32(ConfigurationManager.AppSettings["Default_Wait_Time"]);

        string valid_uname = ConfigurationManager.AppSettings["UserName"];
        string valid_pwrd = ConfigurationManager.AppSettings["Password"];

        string application_url = ConfigurationManager.AppSettings["ApplicationUrl"];
        public Varify_ValidLoginSteps(IWebDriver driver)
        {
            _webDriver = driver;
        }

        [When(@"Enter valid UserName and Password")]
        public void WhenEnterValidUserNameAndPassword()
        {
            mApp.EnterTextBoxValue(ManageObjects.LoginPage.UserName_EditBox(_webDriver), valid_uname);
            mApp.EnterTextBoxValue(ManageObjects.LoginPage.Password_EditBox(_webDriver), valid_pwrd);
        }
        
        [When(@"Click SignIn Button")]
        public void WhenClickSignInButton()
        {
            mApp.ClickElement(ManageObjects.LoginPage.Login_Button(_webDriver));
            System.Threading.Thread.Sleep(default_wait_time);
        }
        
        [Then(@"Account Summary Page should be displayed")]
        public void ThenAccountSummaryPageShouldBeDisplayed()
        {
            Assert.IsTrue(mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.AccountOverviewPage.EditAccountInfo_Button(_webDriver)),"Account Overview page exists..");
        }
    }
}