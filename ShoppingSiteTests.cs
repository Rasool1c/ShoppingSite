using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ShoppingSite.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingSite.Pages;
namespace ShoppingSite
{
    public class Tests
    {
        Homepage homepage = new Homepage();
        LoginPage loginPage = new LoginPage();
        SearchPage searchPage = new SearchPage();
        ProductPage productPage = new ProductPage();
        CartPage cartPage = new CartPage();
        CheckOutPage checkOutPage = new CheckOutPage();
        PaymentPage paymentPage = new PaymentPage();      
        [SetUp]
        public void Setup()
        {
            ShoppingDrivers.driver = new ChromeDriver();
            ShoppingDrivers.driver.Manage().Window.Maximize();
            ShoppingDrivers.driver.Navigate().GoToUrl("https://automationexercise.com/");
            ShoppingDrivers.wait = new WebDriverWait(ShoppingDrivers.driver, TimeSpan.FromSeconds(10));            
        }
        [Test]
        public void Test1()
        {           
            homepage.Go();
            homepage.Login();
            loginPage.Logon();
            homepage.LogonVerify();
            homepage.Product();
            searchPage.SearchFor();
            searchPage.SearchAssert();
            searchPage.ViewProduct();
            productPage.AddToCart();
            productPage.ViewCart();
            cartPage.CheckOut();
            checkOutPage.AddCommentsToProduct();
            checkOutPage.PlaceOrder();
            paymentPage.EnteringPaymentDetails();
            paymentPage.OrderConfirmation();
        }
        [TearDown]
        public void Teardown()
        {
            ShoppingDrivers.driver.Quit();
        }
    }
}