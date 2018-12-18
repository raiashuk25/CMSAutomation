using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace Resources
{

    public class BrowserFactory
    {

        public IWebDriver BrowserTypeCreate(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                case BrowserType.IE:
                    return GetIEDriver();
                case BrowserType.FireFox:
                    return GeFireFoxDriver();
                default:
                    throw new ArgumentOutOfRangeException("No such browser exist");
            }
        }
        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
        private IWebDriver GetIEDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new InternetExplorerDriver(outPutDirectory);
        }
        private IWebDriver GeFireFoxDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new FirefoxDriver(outPutDirectory);
        }
    }
}
