using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_selenium.Course10.Course10_HW
{
    [TestFixture]
    public class HomePageHeaderTests : HomePageTestBase
    {
        [Test]
        public void CheckHeaderImageHomepage()
        {
            IWebElement image = driver.FindElement(By.XPath("//*[@id=\"header\"]/a/img"));
            Assert.IsNotNull(image);
            Assert.IsTrue(image.Displayed);
            image.Click();
        }

        [Test]
        public void CheckHeaderWikiPageHomepage()
        {
            IWebElement wikiPage = driver.FindElement(By.Id("navHeader"));
            Assert.IsNotNull(wikiPage);
            Assert.IsTrue(wikiPage.Displayed);
            wikiPage.Click();
        }

        [Test]
        public void CheckHeaderLinksHomepage()
        {
            var elems = driver.FindElements(By.Id("navHeader"));
            foreach(var elem in elems)
            {
                Assert.True(elem.Displayed);    
            }
        }
    }
}
