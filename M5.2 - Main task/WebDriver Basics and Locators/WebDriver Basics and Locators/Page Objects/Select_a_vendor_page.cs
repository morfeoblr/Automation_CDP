using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using WebDriver_Basics_and_Locators.Page_Objects;

namespace WebDriver_Basics_and_Locators
{
    public class SelectAVendorPage: PageDecorator
    {
        private const string OkButton = "//*[@id='btnOK']";
        private const string Vendor = "//option[@value='e96dad0b-b6a4-4bb7-8c2d-90032d2a4b67']"; // vendor id

        [FindsBy(How = How.XPath, Using = OkButton)]
        private IWebElement okButton;

        [FindsBy(How = How.XPath, Using = Vendor)]
        private IWebElement vendor;

        public SelectAVendorPage(InitialPage initialpage, IWebDriver driver): base(initialpage.pagepath + " Select a vendor ->", initialpage)
        {
            PageFactory.InitElements(driver, this);
        }

        public OldAdminPage SelectTargetVendor(SelectAVendorPage selectAVendorPage)
        {
            vendor.Click();
            okButton.Click();
            return new OldAdminPage(selectAVendorPage, driver);
        }
    }
}
