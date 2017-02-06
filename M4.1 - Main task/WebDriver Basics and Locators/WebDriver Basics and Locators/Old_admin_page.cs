using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver_Basics_and_Locators
{
    public class OldAdminPage
    {
        private static string _division = "//*[@id='ctl00_ctl00_cell3row2']/a";
        private static string _vendorUsers = "//a[@class='Level2NavigationNotSelectedText'][1]";
        private static string _authentificationIdInput = "//*[@id='ctl01_txtUserAccessID']";
        private static string _searchButton = "//*[@id='ctl01_btnSearch']";
        private static string _loginLink = "//a[contains(@onclick,'alexb')][1]";

        public static void LoginAsUser(IWebDriver driver)
        {
            driver.FindElement(By.XPath(_division)).Click();
            driver.FindElement(By.XPath(_vendorUsers)).Click();
            driver.FindElement(By.XPath(_authentificationIdInput)).SendKeys(Resource.User_auth_id);
            driver.FindElement(By.XPath(_searchButton)).Click();
            driver.FindElement(By.XPath(_loginLink)).Click();
        }
    }
}
