using OpenQA.Selenium;

namespace AutomationFramework
{
    internal class AutomationParcticeHomePage : BasePage
    {
        public AutomationParcticeHomePage(IWebDriver driver) : base(driver) { }
        public IWebElement PageLogo => Driver.FindElement(By.Id("header_logo"));
        public IWebElement ItemSearchBoxOnHomePage => Driver.FindElement(By.Id("search_query_top"));
        public IWebElement SearchButton => Driver.FindElement(By.XPath("//*[@id='searchbox']/button"));
        public IWebElement SearchedTShirtItem => Driver.FindElement(By.XPath("//*[contains(text(),'Faded Short Sleeve T-shirts')]"));
        public IWebElement SearchedSummerWearItem => Driver.FindElement(By.XPath("//*[contains(text(),'Printed Summer Dress')]"));
    }
}