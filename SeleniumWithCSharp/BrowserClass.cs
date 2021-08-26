using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWithCSharp
{
    class BrowserClass
    {
        IWebDriver driver;
        
        public IWebDriver getBrowserInstanceCreated(string browser)
        {
            if (browser.ToLower().Equals("chrome"))
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                return driver;
            }
            else
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
                return driver;
            }
        }
    }
}
