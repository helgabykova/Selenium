using OpenQA.Selenium;
using System;


namespace SeleniumTests
{
    public class OfficeTimePages
    {
        protected readonly IWebDriver WebDriver;

        public OfficeTimePages(IWebDriver webdriver)
        {
            
            this.WebDriver = webdriver;

            string title = WebDriver.Title;

            if (!title.Equals("OfficeTime"))
            {
                throw new InvalidOperationException("Not OfficeTime Page. It's a " + title);
            }
        }

        public void VerifyMonthClick()
        {
            IWebElement clickmonth = WebDriver.FindElement(By.XPath("//a[contains(.,'Month')]"));
            clickmonth.Click();
        }
        public void VerifyWeekClick()
        {
            IWebElement clickweek = WebDriver.FindElement(By.XPath("//a[contains(.,'Week')]"));
            clickweek.Click();
        }
        public void VerifyCustomClick()
        {
            IWebElement clickcustm = WebDriver.FindElement(By.XPath("//a[contains(.,'Custom')]"));
            clickcustm.Click();
        }
        public void VerifyTodayClick()
        {
            IWebElement clicktoday = WebDriver.FindElement(By.XPath("//a[contains(.,'Today')]"));
            clicktoday.Click();
        }
        public void VerifyTableClick()
        {
            IWebElement clicktablview = WebDriver.FindElement(By.XPath("//a[contains(.,'Table view')]"));
            clicktablview.Click();
        }
        public void VerifyGraphClick()
        {
            IWebElement clickgraphview = WebDriver.FindElement(By.XPath("//a[contains(.,'Graph view')]"));
            clickgraphview.Click();
        }
    }
}
