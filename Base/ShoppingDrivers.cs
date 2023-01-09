
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSite.Base
{
    internal class ShoppingDrivers
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;
        public static Logger logger = LogManager.GetCurrentClassLogger();
        
    }
}
