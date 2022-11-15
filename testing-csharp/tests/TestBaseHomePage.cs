using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using page_objects.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    [TestFixture]
    public class TestBaseHomePage
    {
        // Create instances
        public IWebDriver driver;
        public Actions actions;
        public HomePage homePage;

        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            actions = new Actions(driver);
            homePage = new HomePage(driver);
        }

        [TearDown]
        public void DestroyDriver()
        {
            driver.Quit();
        }
    }
}
