using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Framework.Tests
{
    [TestFixture]
    class EmptyFieldsBookingTest
    {
        private Steps.Steps steps = new Steps.Steps();

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
            steps.OpenStartPage();
            steps.SetArrival("MIL");
            steps.SelectFlightData();
            steps.PassengersDataInBookingPage("Ann", "Smith");
            steps.PassengersContactsInBookingPage("a@gmail.com", "293105510");
            steps.AcceptDataInFindBookingPage();
            Assert.AreEqual(false, errorMessageInBookingPage());
        }

    }
}

        
    

