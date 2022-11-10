using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course8.Course8_HW
{
    [TestFixture]
    public class HomePage
    {
        [Test]
        public void ClickImage()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement picture = driver.FindElement(By.TagName("img"));
            picture.Click();
            driver.Quit();
        }

        [Test]
        public void ClickWikiPage()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement wikiPageHeader = driver.FindElement(By.Id("navHeader"));
            wikiPageHeader.Click();
        }

        [Test]
        public void CheckPageTitle()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Equals("Home page"));        // Expected - true, Returns - true
            // Assert.IsTrue(driver.Title.Equals("Home Page"));     // Expected - true, Returns - false
            driver.Quit();
        }

        [Test]
        public void CheckTextIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement text = driver.FindElement(By.XPath("/html/body/p"));
            Assert.IsTrue(text.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(text.Displayed);      // Expected - false, Returns - true
            driver.Quit();
        }

        [Test]
        public void CheckDefaultEmailIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement defaultEmail = driver.FindElement(By.XPath("/html/body/b/p[1]"));
            Assert.IsTrue(defaultEmail.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(defaultEmail.Displayed);      // Expected - false, Returns - true
            driver.Quit();
        }

        [Test]
        public void CheckDefaultPasswordIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement defaultPassword = driver.FindElement(By.XPath("/html/body/b/p[2]"));
            Assert.IsTrue(defaultPassword.Displayed);       // Expected - true, Returns - true
            // Assert.IsFalse(defaultPassword.Displayed);   // Expected - false, Returns - true
        }

        [Test]
        public void CheckLoginLabelIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement loginLabel = driver.FindElement(By.Id("myDivHeader"));
            Assert.IsTrue(loginLabel.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(loginLabel.Displayed);      // Expected - false, Returns - true
            driver.Quit();
        }

        [Test]
        public void CheckEmailInputIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement emailInput = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailInput.Displayed);            // Expected - true, Returns - true
            // Assert.IsFalse(emailInpit.Displayed);        // Expected - false, Returns - true
            driver.Quit();
        }

        [Test]
        public void CheckFillEmailInput()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("admin@domain.org");
            driver.Quit();
        }

        [Test]
        public void CheckFillPasswordInput()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("111111");
            driver.Quit();
        }

        [Test]
        public void CheckLoginButtonIsDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsTrue(loginButton.Displayed);           // Expected - true, Returns - true
            // Assert.IsFalse(loginButton.Displayed);       // Expected - false, Returns - true
            driver.Quit();
        }

        [Test]
        public void CheckLoginButtonPressed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
            driver.Quit();
        }

        [Test]
        public void CheckLoginProcess()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("admin@domain.org");
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("111111");
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
            driver.Quit();
        }

        [Test]
        public void CheckHomePageLinkIsVisible()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement homePage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[1]/a"));
            Assert.IsTrue(homePage.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(homePage.Displayed);      // Expected - false, Returns - true
            driver.Quit();
        }

        [Test]
        public void CheckHomePageLinkClicked()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement homePage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[1]/a"));
            homePage.Click();
            driver.Quit();
        }

        [Test]
        public void CheckWikiPageLinkIsVisible()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement wikiPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            Assert.IsTrue(wikiPage.Displayed);          // Expected - true, Returns - true
            // Assert.IsFalse(wikiPage.Displayed);      // Expected - false, Returns - true
            driver.Quit();
        }

        [Test]
        public void CheckWikiPageLinkClicked()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement wikiPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiPage.Click();
            driver.Quit();
        }

        [Test]
        public void CheckContactPageLinkIsVisible()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement contactPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[3]/a"));
            Assert.IsTrue(contactPage.Displayed);           // Expected - true, Returns - true
            // Assert.IsFalse(contactPage.Displayed);       // Expected - false, Returns - true
            driver.Quit();            
        }

        [Test]
        public void CheckContactPageLinkClicked()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            IWebElement contactPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[3]/a"));
            contactPage.Click();
            driver.Quit();
        }

        [Test]
        public void CheckAllElementsAreDisplayed()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/homepage.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Window.Maximize();
            var elems = driver.FindElements(By.XPath("//a[@href]"));
            foreach(var elem in elems)
            {
                Assert.IsTrue(elem.Displayed);
            }
        }
    }
}
