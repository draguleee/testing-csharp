using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using page_objects.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace tests
{
    [TestFixture]
    public class TestBaseDashboardPage
    {
        // Create instances
        public IWebDriver driver;
        public Actions actions;
        public DashboardPage dashboardPage;

        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/dashboardpage.html";
            driver.Manage().Window.Maximize();
            actions = new Actions(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [TearDown]
        public void DestroyDriver()
        {
            driver.Quit();
        }
    }
}
