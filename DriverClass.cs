using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PNC_Bank
{
    public class DriverClass
    {
        public IWebDriver Driver;

        public IWebDriver DriverInitialize(string url)
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
            Task.Delay(2000).Wait();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return Driver;
        }

    }
}
