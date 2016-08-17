using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Remote;

namespace ConsoleApplication2
{
    [TestFixture]
    public class NUnitTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();

            DesiredCapabilities desiredCap = new DesiredCapabilities();
            desiredCap.SetCapability("platform", "Windows");
        }
        [Test]
        public void PortalLogin()

        {
            driver.Url = "https://portal.globallogic.com/access/signin";
            IWebElement login = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[1]/input"));
            login.SendKeys("olga.bykova");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[2]/input"));
            pass.SendKeys("Notulp1994");
            IWebElement submit = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/button"));
            submit.Click();
        }

       
        [Test]
        public void WelcomePopUp()

        {
            driver.Url = "https://portal.globallogic.com";
            IWebElement login = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[1]/input"));
            login.SendKeys("olga.bykova");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[2]/input"));
            pass.SendKeys("Notulp1994");
            IWebElement submit = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/button"));
            submit.Click();
            Thread.Sleep(5000);

            IWebElement popup = driver.FindElement(By.Id("gl-tutorial-modal"));
            popup.FindElement(By.CssSelector("button[ng-click='close()']"));

            IWebElement closepop = driver.FindElement(By.CssSelector("button[ng-click='close()']"));
            closepop.Click();
        }

       
        [Test]
        public void MainNavLinks()

        {
            driver.Url = "https://portal.globallogic.com/";
            IWebElement login = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[1]/input"));
            login.SendKeys("olga.bykova");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[2]/input"));
            pass.SendKeys("Notulp1994");
            IWebElement submit = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/button"));
            submit.Click();
            Thread.Sleep(5000);

            IWebElement popup = driver.FindElement(By.Id("gl-tutorial-modal"));
            popup.FindElement(By.CssSelector("button[ng-click='close()']"));

            IWebElement closepop = driver.FindElement(By.CssSelector("button[ng-click='close()']"));
            closepop.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            IWebElement helpdesk = driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[2]/div/div/div[1]/div/div/div[2]/div/a/div/img"));
            helpdesk.Click();
            
            IWebElement EPR = driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[2]/div/div/div[1]/div/div/div[3]/div/a/div/img"));
            EPR.Click();

            IWebElement GLO = driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[2]/div/div/div[1]/div/div/div[5]/div/a/div/img"));
            GLO.Click();

            IWebElement Mail = driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[2]/div/div/div[1]/div/div/div[6]/div/a/div/img"));
            Mail.Click();

        }
       
        [Test]
        public void OfficeTime()

        {
            driver.Url = "https://olga.bykova:Notulp1994@portal-ua.globallogic.com/officetime/";

            IWebElement clickweek = driver.FindElement(By.XPath("//*[@id='toolbar']/a[1]"));
            clickweek.Click();

            IWebElement clickmonth = driver.FindElement(By.XPath("//*[@id='toolbar']/a[2]"));
            clickmonth.Click();

            IWebElement clickcustm = driver.FindElement(By.XPath("//*[@id='toolbar']/a[3]"));
            clickcustm.Click();

            IWebElement clicktoday = driver.FindElement(By.XPath("//*[@id='toolbar']/a[4]"));
            clicktoday.Click();

            IWebElement clicktablview = driver.FindElement(By.XPath("//*[@id='stats']/a[3]"));
            clicktablview.Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            IWebElement clickgraphview = driver.FindElement(By.XPath("//*[@id='stats']/a[4]"));
            clickgraphview.Click();
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        [TearDown]
        public void EndTest()
        {
                driver.Close();
        }
    }
}

