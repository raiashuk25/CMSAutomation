using Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        public void HomePageOfTheApplication()
        {
            AutomationParcticeHomePage homePage = new AutomationParcticeHomePage(Driver);
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(homePage.PageLogo.Displayed);
            System.Threading.Thread.Sleep(5000);
        }
        public void LaunchTheApplication(BrowserType browser = BrowserType.Chrome)
        {
            var factory = new BrowserFactory();
            Driver = factory.BrowserTypeCreate(browser);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            HomePageOfTheApplication();
        }
        [TestCleanup]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
