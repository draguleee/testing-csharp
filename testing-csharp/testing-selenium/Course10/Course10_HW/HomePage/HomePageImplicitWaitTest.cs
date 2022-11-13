using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course10.Course10_HW.HomePage
{
    [TestFixture]
    public class HomePageImplicitWaitTest : HomePageTestBase
    {
        [Test]
        public void CheckImplicitWaitHomepage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement wikiPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            wikiPage.Click();
        }
    }
}
