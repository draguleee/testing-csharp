using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course10.Course10_HW.HomePage
{
    [TestFixture]
    public class HomePageBodyTests : HomePageTestBase
    {
        [Test]
        public void CheckBodyWikiPageHomepage()
        {
            IWebElement wikiPage = driver.FindElement(By.Id("navHeader"));
            Assert.IsNotNull(wikiPage);
            Assert.IsTrue(wikiPage.Displayed);
            wikiPage.Click();
        }

        [Test]
        public void CheckBodyHtmlTextHomepage()
        {
            IWebElement html = driver.FindElement(By.TagName("h1"));
            Assert.IsNotNull(html);
            Assert.IsTrue(html.Displayed);
        }

        [Test]
        public void CheckBodyTextHomepage()
        {
            IWebElement text = driver.FindElement(By.XPath("/html/body/p"));
            Assert.IsNotNull(text);
            Assert.IsTrue(text.Displayed);
        }

        [Test]
        public void CheckBodyDefaultEmailHomepage()
        {
            IWebElement defaultEmail = driver.FindElement(By.XPath("/html/body/b/p[1]"));
            Assert.IsNotNull(defaultEmail);
            Assert.IsTrue(defaultEmail.Displayed);
        }

        [Test]
        public void CheckBodyDefaultPasswordHomepage()
        {
            IWebElement defaultPassword = driver.FindElement(By.XPath("/html/body/b/p[2]"));
            Assert.IsNotNull(defaultPassword);
            Assert.IsTrue(defaultPassword.Displayed);
        }

        [Test]
        public void CheckBodyLoginLabelHomepage()
        {
            IWebElement loginLabel = driver.FindElement(By.TagName("h2"));
            Assert.IsNotNull(loginLabel);
            Assert.IsTrue(loginLabel.Displayed);
        }

        [Test]
        public void CheckBodyLoginFormHomepage()
        {
            IWebElement emailField = driver.FindElement(By.Id("email"));
            Assert.IsNotNull(emailField);
            Assert.IsTrue(emailField.Displayed);
            emailField.SendKeys("admin@domain.org");
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            Assert.IsNotNull(passwordField);
            Assert.IsTrue(passwordField.Displayed);
            passwordField.SendKeys("111111");
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            Assert.IsNotNull(loginButton);
            Assert.IsTrue(loginButton.Displayed);
            loginButton.Click();
        }

        [Test]
        public void CheckBodyErrorMessagesHomepage()
        {
            IWebElement emailErrorText = driver.FindElement(By.Id("emailErrorText"));
            Assert.IsFalse(emailErrorText.Displayed);
            IWebElement passwordErrorText = driver.FindElement(By.Id("passwordErrorText"));
            Assert.IsFalse(passwordErrorText.Displayed);
            IWebElement loginButton = driver.FindElement(By.Id("Login"));
            loginButton.Click();
            Assert.IsTrue(emailErrorText.Displayed);
            Assert.IsTrue(passwordErrorText.Displayed);
            Assert.IsTrue(emailErrorText.Text.Equals("Email address can't be null"));
            Assert.IsTrue(passwordErrorText.Text.Equals("Password can't be null"));
        }
    }
}
