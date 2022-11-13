using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utils;

namespace testing_selenium.Course10.Course10_HW.HomePage
{
    [TestFixture]
    public class HomePageFluentWaitTest : HomePageTestBase
    {
        [Test]
        public void CheckFluentWaitHomepage()
        {
            Browser browser = new Browser();
            browser.WaitElementToBeVisibleFluent(driver, By.XPath("//*[@id=\"nav\"]/li[2]/a"), 10);
            IWebElement wikiPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiPage.Click();
        }
    }
}
