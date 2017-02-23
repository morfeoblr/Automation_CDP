using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriver_Basics_and_Locators
{
    public class ConfirmationPage: BasePage
    {
        private const string GroupName = "//a[contains(@onclick,'ShowAuthGroup')]";

        [FindsBy(How = How.XPath, Using = GroupName)]
        private IWebElement groupName;

        public ConfirmationPage(IWebDriver driver)
        {
            this.title = "AdBuilder: Checkout";
            PageFactory.InitElements(driver, this);
        }

        public string GetGroupName()
        {
            WaitForElementVisibility(groupName);
            return groupName.Text;
        }
        public string GetTitle()
        {
            return driver.Title;
        }
    }
}
