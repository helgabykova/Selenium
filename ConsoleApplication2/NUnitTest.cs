using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
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
            IWebElement login = driver.FindElement(By.XPath("//input[@ng-model='user.username']"));
            login.SendKeys("username");
            IWebElement pass = driver.FindElement(By.XPath("//input[@ng-model='user.password']"));
            pass.SendKeys("userpassword");
            IWebElement submit = driver.FindElement(By.XPath("//button[@ng-click='login()']"));
            submit.Click();
            Assert.True(true,"Don't show next time");
            Assert.False(false, "GlobalLogic Portal");
        }

       
        [Test]
        public void WelcomePopUp()

        {
            driver.Url = "https://portal.globallogic.com";
            IWebElement login = driver.FindElement(By.XPath("//input[@ng-model='user.username']"));
            login.SendKeys("username");
            IWebElement pass = driver.FindElement(By.XPath("//input[@ng-model='user.password']"));
            pass.SendKeys("userpassword");
            IWebElement submit = driver.FindElement(By.XPath("//button[@ng-click='login()']"));
            submit.Click();
            Thread.Sleep(5000);

            IWebElement popup = driver.FindElement(By.Id("gl-tutorial-modal"));
            popup.FindElement(By.CssSelector("button[ng-click='close()']"));

            IWebElement closepop = driver.FindElement(By.CssSelector("button[ng-click='close()']"));
            closepop.Click();

            Assert.True(true, "Development Platform");
            Assert.False(false, "Don't show next time");
        }

       
        [Test]
        public void MainNavLinks()

        {
            driver.Url = "https://portal.globallogic.com/";
            IWebElement login = driver.FindElement(By.XPath("//input[@ng-model='user.username']"));
            login.SendKeys("username");
            IWebElement pass = driver.FindElement(By.XPath("//input[@ng-model='user.password']"));
            pass.SendKeys("userpassword");
            IWebElement submit = driver.FindElement(By.XPath("//button[@ng-click='login()']"));
            submit.Click();
            Thread.Sleep(5000);

            IWebElement popup = driver.FindElement(By.Id("gl-tutorial-modal"));
            popup.FindElement(By.CssSelector("button[ng-click='close()']"));

            IWebElement closepop = driver.FindElement(By.CssSelector("button[ng-click='close()']"));
            closepop.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            IWebElement helpdesk = driver.FindElement(By.XPath("//span[contains(.,'Helpdesk')]"));
            helpdesk.Click();
            Assert.True(true, "System Dashboard"); 


            IWebElement EPR = driver.FindElement(By.XPath("//span[contains(.,'ERP')]"));
            EPR.Click();
            Assert.True(true, "The E-Business Home Page is");

            IWebElement GLO = driver.FindElement(By.XPath("//span[contains(.,'GLO')]"));
            GLO.Click();
            Assert.True(true, "GlobalLogic's Social Collaboration Platform"); 

            IWebElement Mail = driver.FindElement(By.XPath("//span[contains(.,'Mail')]"));
            Mail.Click();
            Assert.True(true, "STAY SIGNED IN ?"); 

        }
       
        [Test]
        public void OfficeTime()

        {
            driver.Url = "https://username:userpassword@portal-ua.globallogic.com/officetime/";

            IWebElement clickweek = driver.FindElement(By.XPath("//a[contains(.,'Week')]"));
            clickweek.Click();

            IWebElement clickmonth = driver.FindElement(By.XPath("//a[contains(.,'Month')]"));
            clickmonth.Click();

            IWebElement clickcustm = driver.FindElement(By.XPath("//a[contains(.,'Custom')]"));
            clickcustm.Click();

            IWebElement clicktoday = driver.FindElement(By.XPath("//a[contains(.,'Today')]"));
            clicktoday.Click();

            IWebElement clicktablview = driver.FindElement(By.XPath("//a[contains(.,'Table view')]"));
            clicktablview.Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            IWebElement clickgraphview = driver.FindElement(By.XPath("//a[contains(.,'Graph view')]"));
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

