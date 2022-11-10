using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course8
{
    [TestFixture]
    public class FirstSeleniumTests
    {
        [Test]
        public void FirstSeleniumTest()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            Assert.True(driver.Title.Equals("Home page"));
            driver.FindElement(By.Id("email")).SendKeys("admin@domain.org");

            driver.FindElement(By.Id("Login")).Click();
            Assert.True(driver.FindElement(By.Id("email")).Displayed);
            // driver.Quit();
        }
    }
}
