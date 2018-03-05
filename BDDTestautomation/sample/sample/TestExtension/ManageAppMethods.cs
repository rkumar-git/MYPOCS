using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using sample.TestExtension;

namespace CT_Solution.TestExtension
{
    public class ManageAppMethods
    {
        ManageApplication mApp = new ManageApplication();
        int default_wait_time = Convert.ToInt32(ConfigurationSettings.AppSettings["Default_Wait_Time"]);

        //Login to Application
        public bool LaunchApplication(IWebDriver driver, string application_url)
        {
            bool isLoggedIn = false;
            try
            {
                driver.Navigate().GoToUrl(application_url.Trim());
                System.Threading.Thread.Sleep(default_wait_time);
                mApp.ClickElement(ManageObjects.LoginPage.UserName_EditBox(driver));
                isLoggedIn = mApp.IsWebElementDisplayed_And_Enabled(ManageObjects.LoginPage.UserName_EditBox(driver));
            }
            catch (Exception ex)
            {
                Console.WriteLine("LoginRapidApplication:" + ex.Message);
            }
            return isLoggedIn;
        }
    }
}
