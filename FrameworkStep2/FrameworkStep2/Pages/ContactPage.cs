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
    class ContactPage
    {
        private const string url = "http://lowcoster.by/airports/";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@id='fscf_name1']")]
        private IWebElement name;
        [FindsBy(How = How.XPath, Using = "//input[@id='fscf_email1']")]
        private IWebElement email;
        [FindsBy(How = How.XPath, Using = "//input[@id='fscf_field1_2']")]
        private IWebElement messageSubject;
        [FindsBy(How = How.XPath, Using = "//input[@id='fscf_field1_3']")]
        private IWebElement message;
        [FindsBy(How = How.XPath, Using = "//input[@id='fscf_field1_5']")]
        private IWebElement phone;
        [FindsBy(How = How.XPath, Using = "//input[@id='fscf_submit1']")]
        private IWebElement buttonSend;
        [FindsBy(How = How.XPath, Using = "//div[@id='fscf_form_error1']")]
        private IWebElement errorMessageInContactPage;

        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SetContacts(string entryName, string entryEmail, string entryPhone)
        {
            name.SendKeys(entryName);
            email.SendKeys(entryEmail);
            phone.SendKeys(entryPhone);
        }

        public void SetMessages(string entryMessageSubject, string entryMessage)
        {
            messageSubject.SendKeys(entryMessageSubject);
            message.SendKeys(entryMessage);
        }

        public void ClickButtonSend()
        {
            buttonSend.Click();
        }

        public void ErrorMessage()
        {
            errorMessageInContactPage.Click();
        }
    }
}
