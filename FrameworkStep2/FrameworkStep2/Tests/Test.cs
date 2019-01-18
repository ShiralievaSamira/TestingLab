using System;
using NUnit.Framework;
using FrameworkStep2.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStep2.Tests
{
    [TestFixture]
    class Test
    {
        IWebDriver driver;
        private Steps.Steps steps = new Steps.Steps();

        String alertMessage = driver.switchTo().alert().getText();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void EmptyFieldsBookingPage()
        {
            steps.OpenFlightPage();
            steps.SelectEnglishLanguage();
            steps.SetArrival("MIL");
            steps.SelectFlightData();
            steps.AcceptSearch();
            steps.PassengersDataInBookingPage("Ann", "Smith");
            steps.PassengersContactsInBookingPage("a@gmail.com", "293105510");
            steps.AcceptDataInFindBookingPage();
            Assert.AreEqual(false, steps.ErrorMessageBookingPage());
        }

        [Test]
        public void CurrentDaySearch()
        {
            steps.OpenFlightPage();
            steps.SelectOnlyThere();
            steps.SetArrival("MIL");
            steps.AcceptSearch();
            Assert.IsTrue(driver.PageSource.Contains("Извините, но по заданным критериям поиска ничего не найдено."));
        }

        [Test]
        public void ChangeInterfaceLanguage()
        {
            steps.OpenFlightPage();
            steps.SelectEnglishLanguage();
            Assert.IsTrue(driver.PageSource.Contains("Air tickets search"));
        }

        [Test]
        public void ExcessNumberInfants()
        {
            steps.OpenFlightPage();
            steps.SetArrival("MIL");
            steps.SelectNumberInfants("2");
            steps.SelectFlightData();
            steps.AcceptSearch();
            Assert.AreEqual(alertMessage, "The total number of infants can not be higher than adults");
        }

        [Test]
        public void SameDepartureAndArrivalCity()
        {
            steps.OpenFlightPage();
            steps.SelectOnlyThere();
            steps.SetArrival("MSQ");
            steps.AcceptSearch();
            Assert.IsTrue(driver.PageSource.Contains("Извините, но по заданным критериям поиска ничего не найдено."));
        }

        [Test]
        public void SendingMessageInContactPage()
        {
            steps.OpenFlightPage();
            steps.OpenContactPage();
            steps.SetContactsInContactPage("Samira", "Shiralieva", "293113396");
            steps.SetMessagesInContactPage("Message subject", "Some message text");
            steps.AcceptSendInContactPage();
            Assert.AreEqual(false, steps.ErrorMessageContactPage());
        }

        [Test]
        public void SearchTicketsAfterViewingLowcosts()
        {
            steps.OpenFlightPage();
            steps.OpenLowcostPage();
            steps.SelectFindFlightsInLowcostPage();
            Assert.AreEqual(false, steps.DepartureAfterViewingLowcosts());
        }

        [Test]
        public void WritingComment()
        {
            steps.OpenFlightPage();
            steps.OpenAirportsPage();
            steps.SelectVilniusInAirportsPage();
            Assert.AreEqual(false, steps.ErrorMessageInComment());
        }

        [Test]
        public void ChoiceOfParticularAirline()
        {
            steps.OpenFlightPage();
            steps.OpenAirlinesPage();
            steps.SelectBuyInAirlinesPage();
            Assert.AreEqual(false, steps.DepartureAfterViewingAirlines());
        }

        [Test]
        public void ChoiceOfParticularAiport()
        {
            steps.OpenFlightPage();
            steps.OpenAirportsPage();
            steps.SelectVilniusInAirportsPage();
            steps.SelectFindFlightsInAirportsPage();
            Assert.AreEqual(false, steps.DepartureAfterViewingAirports());
        }
    }
}
