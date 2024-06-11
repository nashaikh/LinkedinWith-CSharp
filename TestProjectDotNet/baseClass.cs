using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            Console.WriteLine("Setup: Initializing ChromeDriver");
            var options = new ChromeOptions();
            //options.AddArgument("--headless"); // Run Chrome in headless mode if needed
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            Console.WriteLine("Setup: ChromeDriver initialized");
            driver.Navigate().GoToUrl("https://www.linkedin.com/login?fromSignIn=true&trk=guest_homepage-basic_nav-header-signin");

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown: Quitting ChromeDriver");
            driver.Quit();
            Console.WriteLine("TearDown: ChromeDriver quit");
        }
    }
}