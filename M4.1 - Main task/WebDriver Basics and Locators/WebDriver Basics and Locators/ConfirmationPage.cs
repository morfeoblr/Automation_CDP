using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver_Basics_and_Locators
{
    public class ConfirmationPage: BaseTest
    {
        private static string groupName = "//a[contains(@onclick,'ShowAuthGroup')]";
        public static string GetGroupName(IWebDriver driver)
        {
            WaitForElementVisibilityXPath(driver, groupName);
            return driver.FindElement(By.XPath(groupName)).Text;
        }
    }
}
