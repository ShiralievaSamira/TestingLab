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
    class BookingPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@id='OrdersFlightsPassengers1GenderMISSMISS']")]
        private IWebElement gender;
        [FindsBy(How = How.XPath, Using = "//input[@id='OrdersFlightsPassengers1Name']")]
        private IWebElement passengersName;
        [FindsBy(How = How.XPath, Using = "//input[@id='OrdersFlightsPassengers1Surname']")]
        private IWebElement passengersSurname;
        [FindsBy(How = How.XPath, Using = "//input[@id='OrdersFlightsEmail']")]
        private IWebElement passengersEmail;
        [FindsBy(How = How.XPath, Using = "//input[@id='OrdersFlightsPhone']")]
        private IWebElement passengersPhone;
        [FindsBy(How = How.XPath, Using = "//input[@id='conditions']")]
        private IWebElement acceptanceOfTerms;
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-success btn-lg ladda-button']")]
        private IWebElement buttonReserve;
        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-danger']")]
        public IWebElement errorMessageInBookingPage;

        public BookingPage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void SetGender()
        {
            gender.Click();
        }

        public void SetPassengersName(String recordName)
        {
            passengersName.Clear();
            passengersName.SendKeys(recordName);
            passengersName.SendKeys(Keys.Enter);
        }

        public void SetPassengersSurname(String recordSurname)
        {
            passengersSurname.Clear();
            passengersSurname.SendKeys(recordSurname);
            passengersSurname.SendKeys(Keys.Enter);
        }

        public void SetPassengersEmail(String recordEmail)
        {
            passengersEmail.Clear();
            passengersEmail.SendKeys(recordEmail);
            passengersEmail.SendKeys(Keys.Enter);
        }

        public void SetPassengersPhone(String recordPhone)
        {
            passengersPhone.Clear();
            passengersPhone.SendKeys(recordPhone);
            passengersPhone.SendKeys(Keys.Enter);
        }

        public void AcceptItem()
        {
            acceptanceOfTerms.Click();
            buttonReserve.Click();
        }

        public void ErrorMesage()
        {
            errorMessageInBookingPage.Click();
        }
    }
}
