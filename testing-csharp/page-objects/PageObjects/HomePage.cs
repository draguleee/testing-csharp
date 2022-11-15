using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_objects.PageObjects
{
    public class HomePage
    {
        // Page elements
        public IWebDriver driver;
        private IReadOnlyCollection<IWebElement> header { get { return driver.FindElements(By.Id("header")); } } 
        private IReadOnlyCollection<IWebElement> footer { get { return driver.FindElements(By.Id("nav")); } }
        private IWebElement h1Header { get { return driver.FindElement(By.TagName("h1")); } }
        private IWebElement paragraph { get { return driver.FindElement(By.XPath("/html/body/p")); } }
        private IWebElement defaultEmail { get { return driver.FindElement(By.XPath("/html/body/b/p[1]")); } }
        private IWebElement defaultPassword { get { return driver.FindElement(By.XPath("/html/body/b/p[2]")); } }
        private IWebElement h2Header { get { return driver.FindElement(By.TagName("h2")); } }
        private IWebElement emailField { get { return driver.FindElement(By.Id("email")); } }
        private IWebElement passwordField { get { return driver.FindElement(By.Id("password")); } }
        private IWebElement loginButton { get { return driver.FindElement(By.Id("Login")); } }

        // Constructor
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Check if the header is visible
        public bool isHeaderVisible()
        {
            bool flag = true;
            foreach (var elem in header)
            {
                if (!elem.Displayed)
                    flag = false;
            }
            return flag;
        }

        // Check if the footer is visible
        public bool isFooterVisible()
        {
            bool flag = true;
            foreach (var elem in footer)
            {
                if (!elem.Displayed)
                    flag = false;
            }
            return flag;
        }

        // Fetch h1 text
        public string FetchH1Text()
        {
            return h1Header.Text;
        }

        // Fetch paragraph text
        public string FetchParagraphText()
        {
            return paragraph.Text;
        }

        // Fetch default email text
        public string FetchDefaultEmailText()
        {
            return defaultEmail.Text;
        }

        // Fetch default password text
        public string FetchDefaultPasswordText()
        {
            return defaultPassword.Text;    
        }

        // Fetch h2 text
        public string FetchH2Text()
        {
            return h2Header.Text;   
        }

        // Fill in the email field
        public HomePage FillEmailField()
        {
            emailField.SendKeys("admin@domain.org");
            return this;
        }

        // Fill in the password field
        public HomePage FillPasswordField()
        {
            passwordField.SendKeys("111111");
            return this;
        }

        // Press the login button
        public HomePage LogIn()
        {
            loginButton.Click();
            return this;
        }

    }
}
