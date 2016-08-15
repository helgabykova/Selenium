using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace ConsoleApplication1
{
    class Program
    {
        private static object get;

        static void Main(string[] args)
        {

            //TestPortal
            IWebDriver driver = new ChromeDriver();
            Actions action = new Actions(driver);

            driver.Url = ("https://portal.globallogic.com");
            Thread.Sleep(2000);

            action.MoveToElement(driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[1]/input"))).Perform();

            IWebElement login = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[1]/input"));
            login.SendKeys("ChangeOnYourLogin");

            IWebElement pass = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/div[2]/div[2]/input"));
            pass.SendKeys("ChangeOnYourPassword");

            IWebElement submit = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div[2]/div/div/form/button"));
            submit.Click();
            Thread.Sleep(5000);

            IWebElement popup = driver.FindElement(By.Id("gl-tutorial-modal"));
            popup.FindElement(By.CssSelector("button[ng-click='close()']"));

            IWebElement closepop = driver.FindElement(By.CssSelector("button[ng-click='close()']"));
            closepop.Click();
            Thread.Sleep(2000);

            IWebElement helpdesk = driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[2]/div/div/div[1]/div/div/div[2]/div/a/div/img"));
            helpdesk.Click();
            Thread.Sleep(2000);

            IWebElement EPR = driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[2]/div/div/div[1]/div/div/div[3]/div/a/div/img"));
            EPR.Click();
            Thread.Sleep(2000);

            IWebElement GLO = driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[2]/div/div/div[1]/div/div/div[5]/div/a/div/img"));
            GLO.Click();
            Thread.Sleep(2000);

            IWebElement Mail = driver.FindElement(By.XPath("//*[@id='app']/div[2]/div[2]/div/div/div[1]/div/div/div[6]/div/a/div/img"));
            Mail.Click();
            Thread.Sleep(2000);

            
            driver.Url = ("https://ChangeOnYourLogin:ChangeOnYourPassword@portal-ua.globallogic.com/officetime");
            Thread.Sleep(1000);

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

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");


            IWebElement clickgraphview = driver.FindElement(By.XPath("//*[@id='stats']/a[4]"));
            clickgraphview.Click();
            Thread.Sleep(5000);



            driver.Quit();

        }
    }
}
