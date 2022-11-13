using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utils;

namespace testing_selenium.Course10.Course10_HW.DashboardPage
{
    [TestFixture]
    public class DashboardPageExplicitWaitTest : DashboardPageTestBase
    {
        [Test]
        public void CheckExplicitWaitDashboardpage()
        {
            Browser browser = new Browser();
            browser.WaitElementToBeVisibleExplicit(driver, By.Id("textArea"), 10);
            IWebElement textField = driver.FindElement(By.Id("textArea"));
            textField.SendKeys("Information about the user: Dragu Andre.");
        }
    }
}
