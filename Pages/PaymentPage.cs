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
    internal class PaymentPage
    {
        internal void EnteringPaymentDetails()
        {
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("name_on_card")));
            ShoppingDrivers.logger.Info("Entering payment details");
            ShoppingDrivers.driver.FindElement(By.Name("name_on_card")).SendKeys("rasool a");
            ShoppingDrivers.driver.FindElement(By.Name("card_number")).SendKeys("1234567890");
            ShoppingDrivers.driver.FindElement(By.Name("cvc")).SendKeys("777");
            ShoppingDrivers.driver.FindElement(By.Name("expiry_month")).SendKeys("05");
            ShoppingDrivers.driver.FindElement(By.Name("expiry_year")).SendKeys("2029");
            CaptureScreenshot.TakeScreensot("Payment Details");
            ShoppingDrivers.logger.Info("payment details entered successfully");
            ShoppingDrivers.driver.FindElement(By.Id("submit")).Click();
            CaptureScreenshot.TakeScreensot("Order Confirmed");
            ShoppingDrivers.logger.Info("Clicking on Pay and confirm order button in payment page after entering payment details");
        }

        internal void OrderConfirmation()
        {
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//h2[@class='title text-center']")));
            ShoppingDrivers.logger.Debug("Getting the element text for order placed");
            var Success = ShoppingDrivers.driver.FindElement(By.XPath("//h2[@class='title text-center']")).Text;
            ShoppingDrivers.logger.Debug("Asserting the extracted text with expected text");
            Assert.IsTrue(Success.Contains("ORDER PLACED"), "Order not placed");
            ShoppingDrivers.logger.Info("Assert Passed");
            ShoppingDrivers.logger.Info("Congratulations!!!Order Placed Successfully");
        }
    }
}
