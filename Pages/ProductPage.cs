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
    internal class ProductPage
    {
        internal void AddToCart()
        {
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='btn btn-default cart']")));
            ShoppingDrivers.driver.FindElement(By.XPath("//button[@class='btn btn-default cart']")).Click();
            ShoppingDrivers.logger.Info("Clicked on Add to cart button from the product page");
            CaptureScreenshot.TakeScreensot("Added To Cart");
        }

        internal void ViewCart()
        {
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("View Cart")));
            ShoppingDrivers.driver.FindElement(By.LinkText("View Cart")).Click();
            ShoppingDrivers.logger.Info("opening the cart by clicking on View cart from the window");
        }
    }
}
