using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_nunit.Course7.Course7_HW
{
    [TestFixture]
    public class Test
    {
        // Create a Browser object
        Browser browser = new Browser();

        [Test]
        public void TestStartBrowser()
        {
            Assert.IsTrue(browser.StartBrowser());      // Expected - true, Returned - true
            Assert.IsFalse(browser.StartBrowser());     // Expected - false, Returned - true
        }

        [Test]
        public void TestGetPageTitle()
        {
            Assert.AreEqual("Browser is open.", browser.GetPageTitle());        // Expected - equal, Returned - equal
            Assert.AreEqual("No Browser open.", browser.GetPageTitle());        // Expected - equal, Returned - not equal
            Assert.AreNotEqual("Browser is open.", browser.GetPageTitle());     // Expected - not equal, Returned - equal
            Assert.AreNotEqual("No Browser open.", browser.GetPageTitle());     // Expected - not equal, Returned - not equal
        }

        [Test]
        public void TestGetBrowserWidth()
        {
            Assert.AreEqual(1024, browser.GetBrowserWidth());       // Expected - equal, Returned - equal
            Assert.AreEqual(1920, browser.GetBrowserWidth());       // Expected - equal, Returned - not equal
            Assert.Less(1440, browser.GetBrowserWidth());           // Expected - less, Returned - less
            Assert.Less(920, browser.GetBrowserWidth());            // Expected - less, Returned - greater
            Assert.Greater(920, browser.GetBrowserWidth());         // Expected - greater, Returned - greater
            Assert.Greater(2040, browser.GetBrowserWidth());        // Expected - greater, Returned - less
        }
    }
}
