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
    internal class SearchPage
    {
        internal void SearchFor()
        {
            ShoppingDrivers.wait.Until(ExpectedConditions.ElementIsVisible(By.Id("search_product")));
            string EnterSearchText = "tshirt";
            ShoppingDrivers.driver.FindElement(By.Id("search_product")).SendKeys(EnterSearchText);
            ShoppingDrivers.logger.Info("Entered the search text into the search box");
            ShoppingDrivers.driver.FindElement(By.Id("submit_search")).Click();
            ShoppingDrivers.logger.Info("Clicked on search icon to look for the enetred product");
        }
        public void SearchAssert()
        {
            CaptureScreenshot.TakeScreensot("Search For Tshirt");
            ShoppingDrivers.logger.Debug("Asserting the search results page whether page displaying exact content which user searched for");
            Assert.IsTrue(ShoppingDrivers.driver.Url.Contains("tshirt"));
            ShoppingDrivers.logger.Info("Assert passed");
        }
        internal ProductPage ViewProduct()
        {
            ShoppingDrivers.driver.FindElement(By.XPath("//a[@href='/product_details/30']")).Click();
            ShoppingDrivers.logger.Info("Clicked on the view product from the search results ");
            return new ProductPage();
        }
    }
}
