using OpenQA.Selenium;
using ShoppingSite.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSite.Utility
{
    internal class CaptureScreenshot
    {
        public static void TakeScreensot(string name)
        {

            ((ITakesScreenshot)ShoppingDrivers.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindtree2301\source\repos\ShoppingSite\Screenshots\" + name + ".png");
        }
    }
}
