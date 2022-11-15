using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_objects.PageObjects
{
    public class DashboardPage
    {
        // Page elements
        private IWebDriver driver;
        private IReadOnlyCollection<IWebElement> header { get { return driver.FindElements(By.Id("navHeader")); } }
        private IReadOnlyCollection<IWebElement> footer { get { return driver.FindElements(By.Id("nav")); } }
        private IWebElement h1Heading { get { return driver.FindElement(By.TagName("h1")); } }
        private IWebElement paragraph { get { return driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/p[1]")); } }
        private IWebElement firstNameLabel { get { return driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/label[1]")); } } 
        private IWebElement lastNameLabel { get { return driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/label[2]")); } } 
        private IWebElement firstNameField { get { return driver.FindElement(By.Id("firstname")); } } 
        private IWebElement lastNameField { get { return driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[2]")); } }
        private IWebElement femaleGenderRadiobutton { get { return driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[4]")); } }
        private IWebElement carCheckbox { get { return driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[6]")); } } 
        private IWebElement birthdaySelector { get { return driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[7]")); } }
        private IWebElement fileChooser { get { return driver.FindElement(By.XPath("//*[@id=\"myDiv\"]/form/input[8]")); } } 
        private SelectElement select { get { return new SelectElement(driver.FindElement(By.Id("htmlversions"))); } }
        private IWebElement dropDownList { get { return driver.FindElement(By.Id("htmlversions")); } } 
        private IWebElement textArea { get { return driver.FindElement(By.Id("textArea")); } }
        private IWebElement saveButton { get { return driver.FindElement(By.Id("SaveDetails")); } } 
        private IWebElement detailsSaved { get { return driver.FindElement(By.Id("detailsSavedMessage"));  } }
        private IWebElement logoutButton { get { return driver.FindElement(By.Id("Logout")); } }

        // Constructor
        public DashboardPage(IWebDriver driver)
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
            return h1Heading.Text;
        }

        // Fetch paragraph text
        public string FetchParagraphText()
        {
            return paragraph.Text;
        }

        // Fetch first name label
        public string FetchFirstNameLabel()
        {
            return firstNameLabel.Text;
        }

        // Fetch last name label
        public string FetchLastNameLabel()
        {
            return lastNameLabel.Text;
        }

        // Insert first name in the first name field
        public DashboardPage InsertFirstName()
        {
            firstNameField.Clear();
            firstNameField.SendKeys("Dragu");
            return this;
        }

        // Insert last name in the last name field
        public DashboardPage InsertLastName()
        {
            lastNameField.Clear();
            lastNameField.SendKeys("Andre");
            return this;
        }

        // Click the female gender radio button
        public DashboardPage ClickFemaleRadiobutton()
        {
            femaleGenderRadiobutton.Click();
            return this;
        }

        // Check the car checkbox
        public DashboardPage CheckCarCheckbox()
        {
            carCheckbox.Click();
            return this;
        }

        // Input your birthday
        public DashboardPage InputBirthday()
        {
            birthdaySelector.SendKeys("04161999");
            return this;
        }

        // Choose a file
        public DashboardPage UploadFile()
        {
            fileChooser.SendKeys("C:\\sage.jpg");
            return this;
        }

        // Choose from the dropdown list
        public DashboardPage HtmlVersion()
        {
            select.SelectByValue("5");
            return this;
        }

        // Send keys to text area
        public DashboardPage FillTextArea()
        {
            textArea.SendKeys("Information about the user: Dragu Andre.");
            return this;
        }

        // Save the info
        public DashboardPage SaveInfo()
        {
            saveButton.Click();
            return this;
        }

        // Check if the confirm message is visible
        public string DetailsSavedText()
        {
            return detailsSaved.Text;
        }

        // Log out
        public DashboardPage LogOut()
        {
            logoutButton.Click();
            return this;
        }

    }
}
