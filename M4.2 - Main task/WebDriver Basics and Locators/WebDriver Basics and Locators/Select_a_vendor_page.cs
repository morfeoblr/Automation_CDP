using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriver_Basics_and_Locators
{
    public class SelectAVendorPage: BasePage
    {
        private const string OkButton = "//*[@id='btnOK']";
        private const string Vendor = "//option[@value='e96dad0b-b6a4-4bb7-8c2d-90032d2a4b67']"; // vendor id
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = OkButton)] private IWebElement okButton;
        [FindsBy(How = How.XPath, Using = Vendor)] private IWebElement vendor;

        public SelectAVendorPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HomePage SelectTargetVendor()
        {
            vendor.Click();
            okButton.Click();
            return new HomePage(driver);
        }
    }
}
