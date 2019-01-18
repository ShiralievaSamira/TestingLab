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
    class AirlinesPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//td[@class='buy']")]
        private IWebElement buttonBuy;
        [FindsBy(How = How.XPath, Using = "//input[@id='FlightsSearchFrom']")]
        private IWebElement fieldDeparture;

        public AirlinesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void ClickButtonBuy()
        {
            buttonBuy.Click();
        }
    }
}
