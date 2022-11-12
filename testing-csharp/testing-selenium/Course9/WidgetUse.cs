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

namespace testing_selenium.Course9
{
    public class WidgetUse
    {
        // Set up the WebDriver and Actions components
        IWebDriver driver;
        Actions action;

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

        [Test]
        public void CheckHeaderSectionWikiPage()
        {
            IWebElement header = driver.FindElement(By.Id("header"));
            header.FindElement(By.Id("navHeader")).Click();
        }

        [Test]
        public void CheckHeaderSectionImage()
        {
            IWebElement header = driver.FindElement(By.Id("header"));
            header.FindElement(By.XPath("//a/img")).Click();
        }

        [Test]
        public void CheckFormSection()
        {
            IWebElement form = driver.FindElement(By.Id("myDivHeader"));
            IWebElement loginLabel = form.FindElement(By.XPath("//*[@id=\"myDivHeader\"]/h2"));
            Assert.IsTrue(loginLabel.Displayed);
            IWebElement emailField = form.FindElement(By.XPath("//*[@id=\"email\"]"));
            emailField.SendKeys("admin@domain.org");
            IWebElement passwordField = form.FindElement(By.XPath("//*[@id=\"password\"]"));
            passwordField.SendKeys("111111");
            IWebElement loginButton = form.FindElement(By.XPath("//*[@id=\"Login\"]"));
            loginButton.Click();
        }

        [Test]
        public void CheckFooterSectionHomePage()
        {
            IWebElement footer = driver.FindElement(By.Id("nav"));
            IWebElement homePage = footer.FindElement(By.XPath("//*[@id=\"nav\"]/li[1]/a"));
            homePage.Click();   
        }

        [Test]
        public void CheckFooterSectionWikiPage()
        {
            IWebElement footer = driver.FindElement(By.Id("nav"));
            IWebElement wikiPage = footer.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiPage.Click();   
        }

        [Test]
        public void CheckFooterSectionContactPage()
        {
            IWebElement footer = driver.FindElement(By.Id("nav"));
            IWebElement contactPage = footer.FindElement(By.XPath("//*[@id=\"nav\"]/li[3]/a"));
            contactPage.Click();
        }
    }
}
