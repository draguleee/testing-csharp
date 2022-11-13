using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course10
{
    [TestFixture]
    public class Waits
    {
        // Create instances for WebDriver and Actions
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
            // driver.Quit();
        }

        [Test]
        public void CheckExplicitWait()
        {
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("admin@domain.org");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("111111");
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
            WaitElementToBeVisible(driver, By.Id("textArea"), 10);
            IWebElement textArea = driver.FindElement(By.Id("textArea"));
            textArea.SendKeys("Dragu Andre");
        }

        public void WaitElementToBeVisible(IWebDriver driver, By element, int timeOut)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            var waitCondition = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        [Test]
        public void CheckImplicitWait()
        {
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("admin@domain.org");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("111111");
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement textArea = driver.FindElement(By.Id("textArea"));
            textArea.SendKeys("Dragu Andre");
        }

        [Test]
        public void CheckFluentWait()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found.";
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.Id("Login")));
        }

        // Method to establish if the element is present or not
        private bool IsElementPresent(By element)
        {
            try
            {
                driver.FindElement(element);
                return true;
            }
            catch(NoSuchElementException e)
            {
                return false;
            }
        }
    }
}
