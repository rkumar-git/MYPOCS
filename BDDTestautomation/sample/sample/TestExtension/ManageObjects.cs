using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace sample.TestExtension
{
    public class ManageObjects
    {
        public static class LoginPage
        {
            public static IWebElement element = null;
            // Manage web Objects.
            public static IWebElement UserName_EditBox(IWebDriver driver)
            {
                try
                {
                    element = null;
                    element = driver.FindElement(By.Id("email"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                return element;
            }

            public static IWebElement Password_EditBox(IWebDriver driver)
            {
                try
                {
                    element = null;
                    element = driver.FindElement(By.Id("pass"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                return element;
            }

            public static IWebElement ForgetPassword_Link(IWebDriver driver)
            {
                try
                {
                    element = null;
                    element = driver.FindElement(By.LinkText("Forgot password?"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                return element;
            }

            public static IWebElement Login_Button(IWebDriver driver)
            {
                try
                {
                    element = null;
                    element = driver.FindElement(By.XPath("//*[@id='login-form']/div/button"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                return element;
            }

            public static IWebElement SignOut_Link(IWebDriver driver)
            {
                try
                {
                    element = null;
                    //element = driver.FindElement(By.LinkText("Sign Out"));
                    element = driver.FindElement(By.XPath("//*[@id='header-account']/ul/li[3]/a"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                return element;
            }

            public static IWebElement LogOut_Button(IWebDriver driver)
            {
                try
                {
                    element = null;
                    //element = driver.FindElement(By.LinkText("SIGN OUT"));
                    element = driver.FindElement(By.XPath("//*[@id='header-account']/ul/li[3]/a"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                return element;
            }

            public static IWebElement Application_SignInPage(IWebDriver driver)
            {
                try
                {
                    element = null;
                    element = driver.FindElement(By.Id("email"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("RapidApplication_HomePage:" + ex.Message);
                }
                return element;
            }

            public static IWebElement InvalidLogin_WarningMessage(IWebDriver driver)
            {
                try
                {
                    element = null;
                    element = driver.FindElement(By.XPath("//*[@id='matter']/div[2]/div/ul/li/ul/li/span"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Verify invalid Login message.:" + ex.Message);
                }
                return element;
            }

            public static IWebElement SignInBack_Button(IWebDriver driver)
            {
                try
                {
                    element = null;
                    element = driver.FindElement(By.XPath("//*[@id='matter']/div[2]/div/div/p[2]/a"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SignIn Back button:" + ex.Message);
                }
                return element;
            }
        }

        //Account Overview page
        //*[@id="dashboard-account-info"]/a
        public static class AccountOverviewPage
        {
            public static IWebElement element = null;
            public static IWebElement EditAccountInfo_Button(IWebDriver driver)
            {
                element = null;
                element = driver.FindElement(By.XPath("//*[@id='dashboard-account-info']/a"));
                return element;
            }
        }
    }
}
