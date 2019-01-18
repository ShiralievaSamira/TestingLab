using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace Framework.Pages
{
    class StartPage
    {
        private const string url = "http://lowcoster.by/aviabilet";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@id='FlightsSearchTo']")]
        private IWebElement arrival;
        [FindsBy(How = How.XPath, Using = "//input[@id='FlightsSearchComebackDateVisual']")]
        private IWebElement arrivalDate;
        [FindsBy(How = How.XPath, Using = "//a[@class='ui-datepicker-next ui-corner-all']")]
        private IWebElement arrivalMonth;
        [FindsBy(How = How.XPath, Using = "//span[@class='ui-state-default'][contains(.,'15')]")]
        private IWebElement arrivalDay;
        [FindsBy(How = How.XPath, Using = "//form[@id='flights-main-search']")]
        private IWebElement form;
        [FindsBy(How = How.XPath, Using = "//button[@id='search-submit")]
        private IWebElement buttonSearch;


        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SetArrival(String recordArrival)
        {
            arrival.Clear();
            arrival.SendKeys(recordArrival);
            arrival.SendKeys(Keys.Enter);
        }

        public void SetFlightData()
        {
            arrivalDate.Click();
            arrivalMonth.Click();
            arrivalDay.Click();
        }

        public void ClickButtonSearch()
        {
            form.Click();
            buttonSearch.Click();
        }

    }
}
