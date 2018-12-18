using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Resources;

namespace AutomationFramework
{
    [TestClass]
    public class HomePageTests : BaseTest
    {
        [TestMethod]
        public void SearchTShirtINSearchBox()
        {
            LaunchTheApplication(BrowserType.FireFox);
            HomePage homePageofApplication = new HomePage(Driver);
            homePageofApplication.SearchItemInSearchBox("T-Shirt");
            AutomationParcticeHomePage automationParcticeHomePage = new AutomationParcticeHomePage(Driver);
            Assert.IsTrue(automationParcticeHomePage.SearchedTShirtItem.Text.Contains("T-shirts"), "T-Shirt Item not found in search result");
        }
        [TestMethod]
        public void SearchSummerWearINSearchBox()
        {
            LaunchTheApplication(BrowserType.Chrome);
            AutomationParcticeHomePage automationParcticeHomePage = new AutomationParcticeHomePage(Driver);
            automationParcticeHomePage.ItemSearchBoxOnHomePage.Clear();
            automationParcticeHomePage.ItemSearchBoxOnHomePage.SendKeys("Summer");
            automationParcticeHomePage.SearchButton.Click();
            Assert.IsTrue(automationParcticeHomePage.SearchedSummerWearItem.Text.Contains("Summer"), "Summer Wear, Item not found in search result");
        }
    }
}
