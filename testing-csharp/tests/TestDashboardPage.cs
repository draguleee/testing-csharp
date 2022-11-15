using NUnit.Framework;
using OpenQA.Selenium.DevTools.V105.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    [TestFixture]
    public class TestDashboardPage : TestBaseDashboardPage
    {
        [Test]
        public void CheckHeadersDashboardPage()
        {
            Assert.IsTrue(dashboardPage.isFooterVisible());
        }

        [Test]
        public void CheckFooterDashboardPage()
        {
            Assert.IsTrue(dashboardPage.isFooterVisible());
        }

        [Test]
        public void CheckH1HeadingDashboardPage()
        {
            string h1Text = dashboardPage.FetchH1Text();
            Assert.IsTrue(h1Text.Equals("Dashboard page"));
        }

        [Test]
        public void CheckParagraphDashboardPage()
        {
            string paragraph = dashboardPage.FetchParagraphText();
            Assert.IsTrue(paragraph.Equals("Welcome to dashboard page"));
        }

        [Test]
        public void CheckRegisterProcess()
        {
            dashboardPage.FetchFirstNameLabel();
            dashboardPage.FetchLastNameLabel();
            dashboardPage.InsertFirstName()
                         .InsertLastName()
                         .ClickFemaleRadiobutton()
                         .CheckCarCheckbox()
                         .InputBirthday()
                         .UploadFile()
                         .HtmlVersion()
                         .FillTextArea()
                         .SaveInfo()
                         .DetailsSavedText();
            dashboardPage.LogOut();
        }
    }
}
