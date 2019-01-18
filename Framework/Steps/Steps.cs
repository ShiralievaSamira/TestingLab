using NUnit.Framework;
using Framework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Framework.Steps
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

        public void OpenStartPage()
        {
            StartPage startPage = new StartPage(driver);
            startPage.OpenPage();
        }

        public void SetArrival(String recordArrival)
        {
            StartPage startPage = new StartPage(driver);
            startPage.SetArrival(recordArrival);
        }

        public void SelectFlightData()
        {
            StartPage startPage = new StartPage(driver);
            startPage.SetFlightData();
            startPage.ClickButtonSearch();
        }

        public void PassengersDataInBookingPage(String recordName, String recordSurname)
        {
            BookingPage bookingPage = new BookingPage(driver); 
            bookingPage.SetPassengersName(recordName);
            bookingPage.SetPassengersSurname(recordSurname);
        }

        public bool errorMessageInBookingPage()
        {
            BookingPage bookingPage = new BookingPage(driver);
            return driver.ErrorMessage.Contains("Please enter correct data for your order");
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

    }
}

