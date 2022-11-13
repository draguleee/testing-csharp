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
    public class HomePageFooterTests : HomePageTestBase
    {
        [Test]
        public void CheckFooterHomePageHomepage()
        {
            IWebElement homePage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[1]/a"));
            Assert.IsNotNull(homePage);
            Assert.IsTrue(homePage.Displayed);
            homePage.Click();
        }

        [Test]
        public void CheckHeaderWikiPageHomepage()
        {
            IWebElement wikiPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[2]/a"));
            Assert.IsNotNull(wikiPage);
            Assert.IsTrue(wikiPage.Displayed);
            wikiPage.Click();
        }

        [Test]
        public void CheckFooterContactPageHomepage()
        {
            IWebElement contactPage = driver.FindElement(By.XPath("//*[@id=\"nav\"]/li[3]/a"));
            Assert.IsNotNull(contactPage);
            Assert.IsTrue(contactPage.Displayed);
            contactPage.Click();
        }

        [Test]
        public void CheckFooterLinksHomepage()
        {
            var elems = driver.FindElements(By.Id("nav"));
            foreach(var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
        }
    }
}
