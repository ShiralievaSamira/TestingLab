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
    class FlightPage
    {
        private const string url = "http://lowcoster.by/aviabilet";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//li[@id='menu-item-68']")]
        private IWebElement menuItemContacts;
        [FindsBy(How = How.XPath, Using = "//li[@id='menu-item-2941']")]
        private IWebElement menuItemAirlines;
        [FindsBy(How = How.XPath, Using = "//li[@id='menu-item-1663']")]
        private IWebElement menuItemAirports;
        [FindsBy(How = How.XPath, Using = "//li[@id='menu-item-3628']")]
        private IWebElement menuItemLowcosts;
        [FindsBy(How = How.Id, Using = "dropdownMenuLinkLanguages")]
        private IWebElement menuLanguages;
        [FindsBy(How = How.XPath, Using = "//img[@src='/img/flags/en.gif']")]
        private IWebElement menuEnglishLanguage;
        [FindsBy(How = How.XPath, Using = "//input[@class='form-check-input']")]
        private IWebElement onlyThere;
        [FindsBy(How = How.XPath, Using = "//input[@id='FlightsSearchFrom']")]
        private IWebElement departure;
        [FindsBy(How = How.XPath, Using = "//input[@id='FlightsSearchTo']")]
        private IWebElement arrival;
        [FindsBy(How = How.XPath, Using = "//input[@id='FlightsSearchComebackDateVisual']")]
        private IWebElement arrivalDate;
        [FindsBy(How = How.XPath, Using = "//a[@class='ui-datepicker-next ui-corner-all']")]
        private IWebElement arrivalMonth;
        [FindsBy(How = How.XPath, Using = "//span[@class='ui-state-default'][contains(.,'15')]")]
        private IWebElement arrivalDay;
        [FindsBy(How = How.XPath, Using = "//select[@id='FlightsSearchInfants']")]
        private IWebElement numberInfants;
        [FindsBy(How = How.XPath, Using = "//form[@id='flights-main-search']")]
        private IWebElement form;
        [FindsBy(How = How.XPath, Using = "//button[@id='search-submit']")]
        private IWebElement buttonSearch;
        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-danger']")]
        private IWebElement errorMessageInComment;

        public FlightPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickContacts()
        {
            menuItemContacts.Click();
        }

        public void ClickAirlines()
        {
            menuItemAirlines.Click();
        }

        public void ClickAirports()
        {
            menuItemAirports.Click();
        }

        public void ClickLowcosts()
        {
            menuItemLowcosts.Click();
        }

        public void SetEnglishLanguage()
        {
            menuLanguages.Click();
            menuEnglishLanguage.Click();
        }

        public void ClickButtonOnlyThere()
        {
            onlyThere.Click();
        }

        public void SetDeparture()
        {
            departure.Click();
        }

        public void SetArrival(String recordArrival)
        {
            arrival.Clear();
            arrival.SendKeys(recordArrival);
            arrival.SendKeys(Keys.Enter);
        }

        public void SetFlightDate()
        {
            arrivalDate.Click();
            arrivalMonth.Click();
            arrivalDay.Click();
        }

        public void SetInfants(String recordInfants)
        {
            numberInfants.SendKeys(recordInfants);
            numberInfants.SendKeys(Keys.Enter);
        }

        public void ClickButtonSearch()
        {
            form.Click();
            buttonSearch.Click();
        }
    }
}
