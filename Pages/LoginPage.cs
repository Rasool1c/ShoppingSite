using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingSite.Base;
using ShoppingSite.Utility;

namespace ShoppingSite.Pages
{
    internal class LoginPage
    {
        public void Logon()
        {
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@data-qa='login-email']")));
            ShoppingDrivers.driver.FindElement(By.XPath("//input[@data-qa='login-email']")).SendKeys("miboxij917@irebah.com");
            ShoppingDrivers.logger.Info("Entered username for login");
            ShoppingDrivers.driver.FindElement(By.Name("password")).SendKeys("rasool@123");
            ShoppingDrivers.logger.Info("Entered valid password for login");
            CaptureScreenshot.TakeScreensot("Login Details");
            ShoppingDrivers.driver.FindElement(By.XPath(("//button[@data-qa='login-button']"))).Submit();
            ShoppingDrivers.logger.Info("Clicked on login button from login page");
        }
    }
}
