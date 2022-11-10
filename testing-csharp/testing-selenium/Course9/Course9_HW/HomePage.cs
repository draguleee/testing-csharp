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

namespace testing_selenium.Course9_HW
{
    [TestFixture]
    public class HomePage
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
        public void ClickImage()
        {
            IWebElement picture = driver.FindElement(By.TagName("img"));
            picture.Click();
        }

        [Test]
        public void ClickWikiPage()
        {
            IWebElement wikiPageHeader = driver.FindElement(By.Id("navHeader"));
            wikiPageHeader.Click();
        }

        [Test]
        public void CheckPageTitle()
        {
            Assert.IsTrue(driver.Title.Equals("Home page"));        // Expected - true, Returns - true
            // Assert.IsTrue(driver.Title.Equals("Home Page"));     // Expected - true, Returns - false
        }

        [Test]
        public void CheckTextIsDisplayed()
        {
            IWebElement text = driver.FindElement(By.XPath("/html/body/p"));
            Assert.IsTrue(text.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(text.Displayed);      // Expected - false, Returns - true
        }

        [Test]
        public void CheckDefaultEmailIsDisplayed()
        {
            IWebElement defaultEmail = driver.FindElement(By.XPath("/html/body/b/p[1]"));
            Assert.IsTrue(defaultEmail.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(defaultEmail.Displayed);      // Expected - false, Returns - true
        }

        [Test]
        public void CheckDefaultPasswordIsDisplayed()
        {
            IWebElement defaultPassword = driver.FindElement(By.XPath("/html/body/b/p[2]"));
            Assert.IsTrue(defaultPassword.Displayed);       // Expected - true, Returns - true
            // Assert.IsFalse(defaultPassword.Displayed);   // Expected - false, Returns - true
        }

        [Test]
        public void CheckLoginLabelIsDisplayed()
        {
            IWebElement loginLabel = driver.FindElement(By.Id("myDivHeader"));
            Assert.IsTrue(loginLabel.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(loginLabel.Displayed);      // Expected - false, Returns - true
        }

        [Test]
        public void CheckEmailInputIsDisplayed()
        {
            IWebElement emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);            // Expected - true, Returns - true
            // Assert.IsFalse(emailInpit.Displayed);        // Expected - false, Returns - true
        }

        [Test]
        public void CheckFillEmailInput()
        {
            IWebElement emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("admin@domain.org");
        }

        [Test]
        public void CheckFillPasswordInput()
        {
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("111111");
        }

        [Test]
        public void CheckLoginButtonIsDisplayed()
        {
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButton.Displayed);           // Expected - true, Returns - true
            // Assert.IsFalse(loginButton.Displayed);       // Expected - false, Returns - true
        }

        [Test]
        public void CheckLoginButtonPressed()
        {
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
        }

        [Test]
        public void CheckLoginProcess()
        {
            IWebElement emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("admin@domain.org");
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("111111");
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
        }

        [Test]
        public void CheckHomePageLinkIsVisible()
        {
            IWebElement homePage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[1]/a"));
            Assert.IsTrue(homePage.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(homePage.Displayed);      // Expected - false, Returns - true
        }

        [Test]
        public void CheckHomePageLinkClicked()
        {
            IWebElement homePage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[1]/a"));
            homePage.Click();
        }

        [Test]
        public void CheckWikiPageLinkIsVisible()
        {
            IWebElement wikiPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            Assert.IsTrue(wikiPage.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(wikiPage.Displayed);      // Expected - false, Returns - true
        }

        [Test]
        public void CheckWikiPageLinkClicked()
        {
            IWebElement wikiPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiPage.Click();
        }

        [Test]
        public void CheckContactPageLinkIsVisible()
        {
            IWebElement contactPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[3]/a"));
            Assert.IsTrue(contactPage.Displayed);           // Expected - true, Returns - true
            // Assert.IsFalse(contactPage.Displayed);       // Expected - false, Returns - true
        }

        [Test]
        public void CheckContactPageLinkClicked()
        {
            IWebElement contactPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[3]/a"));
            contactPage.Click();
        }

        [Test]
        public void CheckAllElementsAreDisplayed()
        {
            var elems = driver.FindElements(By.XPath("//a[@href]"));
            foreach (var elem in elems)
            {
                Assert.IsTrue(elem.Displayed);
            }
        }

        [Test]
        public void CheckNoInputFields()
        {
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
            IWebElement emailErrorText = driver.FindElement(By.Id("emailErrorText"));
            IWebElement passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));
            Assert.IsTrue(emailErrorText.Displayed);
            Assert.IsTrue(passwordErrorText.Displayed);
            driver.Navigate().Refresh();
            emailErrorText = driver.FindElement(By.Id("emailErrorText"));
            passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));
            Assert.IsFalse(emailErrorText.Displayed);
            Assert.IsFalse(passwordErrorText.Displayed);
        }

        [Test]
        public void CheckFooterHeaderLinks()
        {
            var elems = driver.FindElements(By.Id("header"));       // Links from Header
            foreach (var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
            elems = driver.FindElements(By.Id("nav"));              // Links from Footer
            foreach (var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
        }
    }
}
