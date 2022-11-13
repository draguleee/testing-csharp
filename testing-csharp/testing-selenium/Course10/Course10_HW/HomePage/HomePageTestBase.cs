using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course10.Course10_HW
{
    [TestFixture]
    public class HomePageTestBase
    {
        // Create the WebDriver and Actions instances
        public IWebDriver driver;
        public Actions action;

        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            action = new Actions(driver);
        }

        [TearDown]
        public void DestroyDriver()
        {
            driver.Quit();
        }
    }
}
