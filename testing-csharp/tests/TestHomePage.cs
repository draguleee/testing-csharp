using NUnit.Framework;
using page_objects.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    [TestFixture]
    public class TestHomePage : TestBaseHomePage
    {
        [Test]
        public void CheckHeadersHomePage()
        {
            Assert.IsTrue(homePage.isFooterVisible());
        }

        [Test]
        public void CheckFooterDashboardPage()
        {
            Assert.IsTrue(homePage.isFooterVisible());
        }

        [Test]
        public void CheckH1HeadingHomePage()
        {
            string h1Text = homePage.FetchH1Text();
            Assert.IsTrue(h1Text.Equals("HTML"));
        }

        [Test]
        public void CheckParagraphHomePage()
        {
            string paragraph = homePage.FetchParagraphText();
            Assert.IsTrue(paragraph.Contains("HyperText Markup Language"));
        }

        [Test]
        public void CheckH2HeadingHomePage()
        {
            string h2Text = homePage.FetchH2Text();
            Assert.IsTrue(h2Text.Equals("Login"));
        }

        [Test]
        public void CheckLoginProcess()
        {
            homePage.FillEmailField()
                    .FillPasswordField()
                    .LogIn();
        }
    }
}
