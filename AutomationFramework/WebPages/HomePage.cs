using System;
using OpenQA.Selenium;

namespace AutomationFramework
{
    internal class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }
        public void SearchItemInSearchBox(string itemToSearch)
        {
            AutomationParcticeHomePage automationParcticeHomePage = new AutomationParcticeHomePage(Driver);
            automationParcticeHomePage.ItemSearchBoxOnHomePage.Clear();
            automationParcticeHomePage.ItemSearchBoxOnHomePage.SendKeys(itemToSearch);
            automationParcticeHomePage.SearchButton.Click();
        }
    }
}