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
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course9
{
    public class UserInteractions
    {
        // Set up the WebDriver and Actions objects
        IWebDriver driver;
        Actions action;

        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "file:///C:/Users/aandr/Downloads/Pages/Pages/dashboardpage.html";
            driver.Manage().Window.Maximize();
            action = new Actions(driver);  
        }

        [TearDown]
        public void DestroyDriver()
        {
            driver.Quit();
        }

        [Test]
        public void CheckHeaderSectionImage()
        {
            IWebElement header = driver.FindElement(By.Id("header"));
            IWebElement image = header.FindElement(By.XPath("//a/img"));
            image.Click();
        }

        [Test]
        public void CheckDashboardSection()
        {
            // Create the Dashboard division
            IWebElement dashboard = driver.FindElement(By.Id("myDiv"));

            // Send keys to first name field
            IWebElement firstNameField = dashboard.FindElement(By.Id("firstname"));
            firstNameField.GetAttribute("value");
            firstNameField.GetAttribute("type");
            firstNameField.Clear();
            firstNameField.SendKeys("Dragu");

            // Send keys to last name field
            IWebElement lastNameField = dashboard.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[2]"));
            lastNameField.GetAttribute("value");
            lastNameField.GetAttribute("type");
            lastNameField.Clear();
            lastNameField.SendKeys("Andre");

            // Check the gender radiobutton (female)
            IWebElement gender = dashboard.FindElement(By.CssSelector("input[name='gender'][value='female']"));
            gender.Click();

            // Check the vehicle checkbox (I have a car)
            IWebElement vehicle = dashboard.FindElement(By.CssSelector("input[name='vehicle2']"));
            vehicle.Click();

            // Select your birthday
            IWebElement birthday = dashboard.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[7]"));
            birthday.SendKeys("16041999");

            // Select file upload
            IWebElement uploadFile = dashboard.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[8]"));
            uploadFile.SendKeys("C:\\sage.jpg");

            // Select from the dropdown list
            IWebElement dropDown = dashboard.FindElement(By.Id("htmlversions"));
            SelectElement element = new SelectElement(dropDown);
            element.SelectByValue("5");

            // Send keys to text area
            IWebElement textArea = dashboard.FindElement(By.Id("textArea"));
            textArea.SendKeys("Information about the user: Dragu Andre");

            // Save the details
            IWebElement saveButton = dashboard.FindElement(By.Id("SaveDetails"));
            saveButton.Click();

            // Check if the "Details saved" message is visible
            IWebElement detailsSavedMessage = dashboard.FindElement(By.Id("detailsSavedMessage"));
            Assert.IsTrue(detailsSavedMessage.Displayed);

            // Log out
            IWebElement logoutButton = dashboard.FindElement(By.Id("Logout"));
            logoutButton.Click();

        }
    }
}
