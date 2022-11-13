using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course10.Course10_HW.DashboardPage
{
    [TestFixture]
    public class DashboardPageImplicitWaitTest : DashboardPageTestBase
    {
        [Test]
        public void CheckImplicitWaitDashboardpage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement textField = driver.FindElement(By.Id("textArea"));
            textField.SendKeys("Information about the user: Dragu Andre.");
        }
    }
}
