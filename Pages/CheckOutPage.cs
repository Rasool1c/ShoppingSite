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
    internal class CheckOutPage
    {
        internal void AddCommentsToProduct()
        {
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("message")));
            ShoppingDrivers.logger.Info("Adding comments to the product");
            ShoppingDrivers.driver.FindElement(By.Name("message")).SendKeys("Please Deliver Fast");
            CaptureScreenshot.TakeScreensot("Comments for Product");
        }

        internal void PlaceOrder()
        {
            ShoppingDrivers.driver.FindElement(By.LinkText("Place Order")).Click();
            ShoppingDrivers.logger.Info("Clicking on the place order button from Checkout page");
        }
    }
}
