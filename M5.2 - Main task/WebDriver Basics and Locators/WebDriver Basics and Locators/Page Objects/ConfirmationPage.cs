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
using WebDriver_Basics_and_Locators.Utils;

namespace WebDriver_Basics_and_Locators
{
    public class ConfirmationPage: BaseTest
    {
        private const string GroupName = "//a[contains(@onclick,'ShowAuthGroup')]";

        [FindsBy(How = How.XPath, Using = GroupName)]
        private IWebElement groupName;

        public ConfirmationPage()
        {
            this.title = "AdBuilder: Checkout";
            PageFactory.InitElements(Driver.Instance, this);
        }

        public string GetGroupName()
        {
            WaitForElementVisibility(groupName);
            return groupName.Text;
        }
        public string GetTitle()
        {
            return Driver.Instance.Title;
        }
    }
}
