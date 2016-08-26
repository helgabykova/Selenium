using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTests
{

    [TestFixture]
    public class PortalTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }


        [Test]
        public void VerifyThatYouCanLogin()
        {
            _driver.Url = "https://portal.globallogic.com/access/signin";

            PortalPages login = new PortalPages(_driver);

            login.EnterUsername = "username";

            login.EnterPassword = "userpassword";

            login.ClickLogin();

            Assert.IsTrue(_driver.PageSource.Contains("GlobalLogic Portal"));

        }

        [Test]
        public void VerifyThatYouCanCloseWelcomePopUp()
        {
            VerifyThatYouCanLogin();
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            PortalPages popup = new PortalPages(_driver);

            popup.PopUpFind();

            popup.ClosePoP();

            Assert.IsFalse(_driver.PageSource.Contains("Don't show next time"));
        }

        [Test]
        public void VerifyThatYouCanOpenLinksInMainNav()
        {

            VerifyThatYouCanCloseWelcomePopUp();

            PortalPages mainnav = new PortalPages(_driver);

            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); 

            mainnav.ClickEPR();

            mainnav.ClickHelpdesk();

            mainnav.ClickGLO();

            mainnav.ClickMail();
        }

        [TearDown]
        public void EndTest()
        {
            _driver.Close();
        }
    }
}


