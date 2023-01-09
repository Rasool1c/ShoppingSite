using NUnit.Framework;
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
    internal class Homepage
    {
        public void Go()
        {
            var URL = "https://automationexercise.com/";
            ShoppingDrivers.logger.Info("Navigated to the URL : " + URL);
            CaptureScreenshot.TakeScreensot("Homepage without Login");
        }

        internal LoginPage Login()
        {
            ShoppingDrivers.driver.FindElement(By.XPath("//a[@href='/login']")).Click();
            ShoppingDrivers.logger.Info("Clicked on login button in the homepage");
            return new LoginPage();
        }
        public void LogonVerify()
        {
            //1
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@href='/logout']")));
            ShoppingDrivers.logger.Info("Verifying the Login");
            string OnText = ShoppingDrivers.driver.FindElement(By.XPath("//a[@href='/logout']")).Text;
            ShoppingDrivers.logger.Debug("Asserting the element text with expected text");
            Assert.IsTrue(OnText.Contains("Logout"), "not logged");
            ShoppingDrivers.logger.Info("Login verified successfully");
            //2
            ShoppingDrivers.logger.Info("Verifying the Login with another element");
            string UserNameVerify = ShoppingDrivers.driver.FindElement(By.XPath("//i[@class='fa fa-user']/..")).Text;
            ShoppingDrivers.logger.Debug("Asserting the element text with expected text");
            Assert.IsTrue(UserNameVerify.Contains("rasool"), "wrong user");
            ShoppingDrivers.logger.Info("Login verified successfully");
            CaptureScreenshot.TakeScreensot("Homepage with Login");
        }

        internal SearchPage Product()
        {
            ShoppingDrivers.driver.FindElement(By.XPath("//a[@href='/products']")).Click();
            ShoppingDrivers.logger.Info("Clicked on products button in Homepage");
            Thread.Sleep(3000);
            ShoppingDrivers.driver.Navigate().Refresh();
            ShoppingDrivers.logger.Debug("Refreshing the page");
            if (!ShoppingDrivers.driver.Title.Contains("Products"))
            {
                ShoppingDrivers.logger.Warn("Products page not opened yet, thus clicking on products again");
                ShoppingDrivers.driver.FindElement(By.XPath("//a[@href='/products']")).Click();
                ShoppingDrivers.logger.Info("Clicked on products button in Homepage");
            }
            return new SearchPage();
        }
    }
}
