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
    public class DashboardPageHeaderTests : DashboardPageTestBase
    {
        [Test]
        public void CheckHeaderImageDashboardpage()
        {
            IWebElement image = driver.FindElement(By.XPath("//*[@id=\"header\"]/a/img"));
            Assert.IsNotNull(image);
            Assert.IsTrue(image.Displayed);
            image.Click();
        }

        [Test]
        public void CheckHeaderHomePageDashboardpage()
        {
            IWebElement homePage = driver.FindElement(By.XPath("//*[@id=\"navHeader\"]/a[1]"));
            Assert.IsNotNull(homePage);
            Assert.IsTrue(homePage.Displayed);
            homePage.Click();
        }

        [Test]
        public void CheckHeaderWikiPageDashoardpage()
        {
            IWebElement wikiPage = driver.FindElement(By.XPath("//*[@id=\"navHeader\"]/a[2]"));
            Assert.IsNotNull(wikiPage);
            Assert.IsTrue(wikiPage.Displayed);
            wikiPage.Click();
        }

        [Test]
        public void CheckHeaderLinksDashboardpage()
        {
            var elems = driver.FindElements(By.Id("navHeader"));
            foreach (var elem in elems)
            {
                Assert.True(elem.Displayed);
            }
        }
    }
}
