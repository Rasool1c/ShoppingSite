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
    internal class CartPage
    {
        internal void CheckOut()
        {
            CaptureScreenshot.TakeScreensot("Cart Page");
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='btn btn-default check_out']")));
            ShoppingDrivers.driver.FindElement(By.XPath("//a[@class='btn btn-default check_out']")).Click();
            ShoppingDrivers.logger.Debug("Clicking on checkout button from Cart page");
        }
    }
}
