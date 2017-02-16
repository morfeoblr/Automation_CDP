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
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = GroupName)] private IWebElement groupName;

        public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
            this.title = "Confirmation";
        }

        public string GetGroupName(IWebDriver driver)
        {
            WaitForElementVisibilityXPath(driver, groupName);
            return groupName.Text;
        }
    }
}
