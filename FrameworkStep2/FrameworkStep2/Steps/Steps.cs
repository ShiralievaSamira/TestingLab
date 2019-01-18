using System;
using NUnit.Framework;
using FrameworkStep2.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStep2.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void OpenFlightPage()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.OpenPage();
        }

        public void OpenContactPage()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.ClickContacts();
        }

        public void OpenAirlinesPage()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.ClickAirlines();
        }

        public void OpenAirportsPage()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.ClickAirports();
        }

        public void OpenLowcostPage()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.ClickLowcosts();
        }

        public void SelectEnglishLanguage()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.SetEnglishLanguage();
        }

        public void SelectOnlyThere()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.ClickButtonOnlyThere();
        }

        public void SetArrival(String recordArrival)
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.SetArrival(recordArrival);
        }

        public void SelectFlightData()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.SetFlightDate();
        }

        public void AcceptSearch()
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.ClickButtonSearch();
        }

        public void SelectNumberInfants(String recordInfants)
        {
            FlightPage flightPage = new FlightPage(driver);
            flightPage.SetInfants(recordInfants);
        }

        public bool DepartureAfterViewingLowcosts()
        {
            FlightPage flightPage = new FlightPage(driver);
            return driver.SetDeparture.Contains("VNO");
        }

        public bool DepartureAfterViewingAirports()
        {
            FlightPage flightPage = new FlightPage(driver);
            return driver.SetDeparture.Contains("VNO");
        }

        public bool DepartureAfterViewingAirlines()
        {
            FlightPage flightPage = new FlightPage(driver);
            return driver.SetDeparture.Contains("WAW");
        }

        public void PassengersDataInBookingPage(String recordName, String recordSurname)
        {
            BookingPage bookingPage = new BookingPage(driver);
            bookingPage.SetPassengersName(recordName);
            bookingPage.SetPassengersSurname(recordSurname);
        }

        public void PassengersContactsInBookingPage(String recordEmail, String recordPhone)
        {
            BookingPage bookingPage = new BookingPage(driver);
            bookingPage.SetPassengersEmail(recordEmail);
            bookingPage.SetPassengersPhone(recordPhone);
        }

        public void AcceptDataInFindBookingPage()
        {
            BookingPage bookingPage = new BookingPage(driver);
            bookingPage.SetGender();
            bookingPage.AcceptItem();
        }

        public bool ErrorMessageBookingPage()
        {
            Pages.BookingPage bookingPage = new Pages.BookingPage(driver);
            return driver.ErrorMessage.Contains("Please enter correct data for your order");
        }

        public void SetContactsInContactPage(string entryName, string entryEmail, string entryPhone)
        {
            ContactPage contactPage = new ContactPage(driver);
            contactPage.SetContacts(entryName, entryEmail, entryPhone);
        }

        public void SetMessagesInContactPage(string entryMessageSubject, string entryMessage)
        {
            ContactPage contactPage = new ContactPage(driver);
            contactPage.SetMessages(entryMessageSubject, entryMessage);
        }

        public void AcceptSendInContactPage()
        {
            ContactPage contactPage = new ContactPage(driver);
            contactPage.ClickButtonSend();
        }

        public bool ErrorMessageContactPage()
        {
            ContactPage contactPage = new ContactPage(driver);
            return driver.ErrorMessage.Contains("Пожалуйста, исправьте введенные данные и попробуйте отправить еще раз.");
        }

        public bool ErrorMessageInComment()
        {
            AirlinesPage airlinesPage = new AirlinesPage(driver);
            return driver.ErrorMessage.Contains("Пожалуйста, заполните необходимые поля.");
        }

        public void SelectBuyInAirlinesPage()
        {
            AirlinesPage airlinesPage = new AirlinesPage(driver);
            airlinesPage.ClickButtonBuy();
        }

        public void SelectVilniusInAirportsPage()
        {
            AirportsPage airportsPage = new AirportsPage(driver);
            airportsPage.SetVilnius();
        }

        public void SelectFindFlightsInAirportsPage()
        {
            AirportsPage airportsPage = new AirportsPage(driver);
            airportsPage.ClickButtonFindFlights();
        }

        public void SelectFindFlightsInLowcostPage()
        {
            LowcostPage lowcostPage = new LowcostPage(driver);
            lowcostPage.ClickButtonSearchTickets();
        }
    }
}

