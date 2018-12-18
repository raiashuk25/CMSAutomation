using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Resources;
using excel = Microsoft.Office.Interop.Excel;
using Microsoft.CSharp;

namespace AutomationFramework
{
    [TestClass]
    public class Rough : BaseTest
    {
        [TestMethod]
        public void ExcelTest()
        {
            LaunchTheApplication(BrowserType.Chrome);
            AutomationParcticeHomePage automationParcticeHomePage = new AutomationParcticeHomePage(Driver);
            automationParcticeHomePage.ItemSearchBoxOnHomePage.Clear();
            automationParcticeHomePage.ItemSearchBoxOnHomePage.SendKeys(DataReading(1,2));
            automationParcticeHomePage.ItemSearchBoxOnHomePage.Clear();
            automationParcticeHomePage.ItemSearchBoxOnHomePage.SendKeys(DataReading(2, 2));
            automationParcticeHomePage.ItemSearchBoxOnHomePage.Clear();
            automationParcticeHomePage.ItemSearchBoxOnHomePage.SendKeys(DataReading(3, 2));
            automationParcticeHomePage.ItemSearchBoxOnHomePage.Clear();
            automationParcticeHomePage.SearchButton.Click();
            Assert.IsTrue(automationParcticeHomePage.SearchedSummerWearItem.Text.Contains("Summer"), "Summer Wear, Item not found in search result");
        }
        public string DataReading(int rowNum, int columnNum)
        {
            excel.Application xlApp = new excel.Application();
            excel.Workbook xlWorkBook = xlApp.Workbooks.
                Open(@"C:\Users\raias\Desktop\workspace\SeleniumAutomation\AutomationFramework\CMSAutomation\AutomationFramework\Data\DataFile.xlsx");
            excel.Worksheet worksheet = xlWorkBook.Sheets[1];
            excel.Range range = worksheet.UsedRange;
            string valueFromCell;
            if (range.Cells[rowNum][columnNum].value2 is string)
            {
                return valueFromCell = range.Cells[rowNum][columnNum].value2;
            }
            else
            {
                return valueFromCell = range.Cells[rowNum][columnNum].value2.ToString();
            }
            
        }
    }
}
