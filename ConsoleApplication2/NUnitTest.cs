using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

namespace ConsoleApplication2
{
    [TestFixture]
    public class NUnitTest
    {
        IWebDriver driver;
        TimeSpan span = TimeSpan.FromSeconds(10);

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void PortalLogin()

        {
            driver.Url = "https://portal.globallogic.com";
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
            Thread.Sleep(5000);

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
            driver.Url = "https://olga.bykova:Notulp1994@portal-ua.globallogic.com/officetime";

            IWebElement clickweek = driver.FindElement(By.XPath("//*[@id='toolbar']/a[1]"));
            clickweek.Click();
            Thread.Sleep(2000);

            IWebElement clickmonth = driver.FindElement(By.XPath("//*[@id='toolbar']/a[2]"));
            clickmonth.Click();
            Thread.Sleep(2000);

            IWebElement clickcustm = driver.FindElement(By.XPath("//*[@id='toolbar']/a[3]"));
            clickcustm.Click();
            Thread.Sleep(2000);

            IWebElement clicktoday = driver.FindElement(By.XPath("//*[@id='toolbar']/a[4]"));
            clicktoday.Click();
            Thread.Sleep(2000);

            IWebElement clicktablview = driver.FindElement(By.XPath("//*[@id='stats']/a[3]"));
            clicktablview.Click();
            Thread.Sleep(2000);

            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            //Thread.Sleep(2000);

            IWebElement clickgraphview = driver.FindElement(By.XPath("//*[@id='stats']/a[4]"));
            clickgraphview.Click();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void EndTestOfficeTime()
        {
            driver.Close();
        }
    }
}

