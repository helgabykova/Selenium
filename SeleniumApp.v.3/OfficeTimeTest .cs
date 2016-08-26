using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTests
{

    [TestFixture]
    public class OfficeTimeTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }


        [Test]
        public void VerifyOfficeTimePage()
        {
            _driver.Url = "https://username:userpassword@portal-ua.globallogic.com/officetime/";

            OfficeTimePages officetime = new OfficeTimePages(_driver);

            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            officetime.VerifyMonthClick();

            officetime.VerifyWeekClick();

            officetime.VerifyCustomClick();

            officetime.VerifyTodayClick();

            officetime.VerifyTableClick();

            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

            officetime.VerifyGraphClick();
        }

        [TearDown]
        public void EndTest()
        {
            _driver.Close();
        }
    }
}


