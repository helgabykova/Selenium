using OpenQA.Selenium;
using System;


namespace SeleniumTests
{
    public class PortalPages
    {
        protected readonly IWebDriver WebDriver;

        public PortalPages(IWebDriver webdriver)
        {
            
            this.WebDriver = webdriver;

            string title = WebDriver.Title;

            if (!title.Equals("GlobalLogic Portal"))
            {
                throw new InvalidOperationException("Not Login Page. It's a " + title);
            }
        }
        public string EnterUsername
        {
            set
            {
                IWebElement usernameField = WebDriver.FindElement(By.XPath("//input[@placeholder='User Name']"));
                usernameField.Clear();
                usernameField.SendKeys(value);
            }
        }

        public string EnterPassword
        {
            set
            {
                IWebElement passwordField = WebDriver.FindElement(By.XPath("//input[@placeholder='Password']"));
                passwordField.Clear();
                passwordField.SendKeys(value);
            }
        }

        public void ClickLogin()
        {
            IWebElement loginButton = WebDriver.FindElement(By.XPath("//button[@ng-click='login()']")); 
            loginButton.Click(); 
        }


        public void PopUpFind()
        {
            IWebElement popupfind = WebDriver.FindElement(By.Id("gl-tutorial-modal"));
            popupfind.FindElement(By.CssSelector("button[ng-click='close()']"));
        }

        public void ClosePoP()
        {
            IWebElement closepopup = WebDriver.FindElement(By.CssSelector("button[ng-click='close()']"));
            closepopup.Click();
        }

        public void ClickHelpdesk()
        {
            IWebElement helpdesklink = WebDriver.FindElement(By.XPath("//span[contains(.,'Helpdesk')]"));
            helpdesklink.Click();
        }

        public void ClickEPR()
        {
            IWebElement EPRlink = WebDriver.FindElement(By.XPath("//span[contains(.,'ERP')]"));
            EPRlink.Click();
        }

        public void ClickGLO()
        {
            IWebElement GLOlink = WebDriver.FindElement(By.XPath("//span[contains(.,'GLO')]"));
            GLOlink.Click();
        }

        public void ClickMail()
        {
            IWebElement Maillink = WebDriver.FindElement(By.XPath("//span[contains(.,'Mail')]"));
            Maillink.Click();
        }
    }
}
