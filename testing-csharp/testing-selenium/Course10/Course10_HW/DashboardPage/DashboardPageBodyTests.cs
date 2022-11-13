using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course10.Course10_HW.DashboardPage
{
    [TestFixture]
    public class DashboardPageBodyTests : DashboardPageTestBase
    {
        [Test]
        public void CheckH1Dashboardpage()
        {
            IWebElement h1 = driver.FindElement(By.TagName("h1"));
            Assert.IsNotNull(h1);
            Assert.IsTrue(h1.Displayed);
        }

        [Test]
        public void CheckWelcomeMessageDashboardpage()
        {
            IWebElement welcomeMessage = driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/p[1]"));
            Assert.IsNotNull(welcomeMessage);
            Assert.IsTrue(welcomeMessage.Displayed);
        }

        [Test]
        public void CheckFormDashboardpage()
        {
            // Check if the First Name and the Last Name labels are visible
            IWebElement firstNameLabel = driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/label[1]"));
            Assert.IsNotNull(firstNameLabel);
            Assert.IsTrue(firstNameLabel.Displayed);
            IWebElement lastNameLabel = driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/label[2]"));
            Assert.IsNotNull(lastNameLabel);
            Assert.IsTrue(lastNameLabel.Displayed);

            // Send text to First Name and Last Name fields
            IWebElement firstNameField = driver.FindElement(By.Id("firstname"));
            Assert.IsNotNull(firstNameField);
            Assert.IsTrue(firstNameField.Displayed);
            firstNameField.Clear();
            firstNameField.SendKeys("Dragu");
            IWebElement lastNameField = driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[2]"));
            Assert.IsNotNull(lastNameField);
            Assert.IsTrue(lastNameField.Displayed);
            lastNameField.Clear();
            lastNameField.SendKeys("Andre");

            // Check the radio button
            IWebElement gender = driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[4]"));
            Assert.IsNotNull(gender);
            Assert.IsTrue(gender.Displayed);
            gender.Click();

            // Check the checkbox 
            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[6]"));
            Assert.IsNotNull(vehicle);
            Assert.IsTrue(vehicle.Displayed);
            vehicle.Click();

            // Select the birthday
            IWebElement birthday = driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[7]"));
            Assert.IsNotNull(birthday);
            Assert.IsTrue(birthday.Displayed);
            birthday.SendKeys("16041999");

            // Upload file
            IWebElement uploadFile = driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[8]"));
            Assert.IsNotNull(uploadFile);
            Assert.IsTrue(uploadFile.Displayed);
            uploadFile.SendKeys("C:\\sage.jpg");

            // Choose from the dropdown list
            IWebElement dropDown = driver.FindElement(By.Id("htmlversions"));
            Assert.IsNotNull(dropDown);
            Assert.IsTrue(dropDown.Displayed);
            SelectElement element = new SelectElement(dropDown);
            element.SelectByValue("5");

            // Send keys to text area
            IWebElement textArea = driver.FindElement(By.Id("textArea"));
            Assert.IsNotNull(textArea);
            Assert.IsTrue(textArea.Displayed);
            textArea.SendKeys("Information about the user: Dragu Andre");

            // Save the details
            IWebElement saveButton = driver.FindElement(By.Id("SaveDetails"));
            Assert.IsNotNull(saveButton);
            Assert.IsTrue(saveButton.Displayed);
            saveButton.Click();

            // Check if the "Details saved" message is visible
            IWebElement detailsSavedMessage = driver.FindElement(By.Id("detailsSavedMessage"));
            Assert.IsNotNull(detailsSavedMessage);
            Assert.IsTrue(detailsSavedMessage.Displayed);
        }
    }
}
