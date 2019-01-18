using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStep2.Pages
{
    class AirportsPage
    {
        private const string url = "http://lowcoster.by/airports/";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[@class='city_rus']")]
        private IWebElement buttonVilnius;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn- ']")]
        private IWebElement findFlights;

        public AirportsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SetVilnius()
        {
            buttonVilnius.Click();
        }

        public void ClickButtonFindFlights()
        {
            findFlights.Click();
        }
    }
}
