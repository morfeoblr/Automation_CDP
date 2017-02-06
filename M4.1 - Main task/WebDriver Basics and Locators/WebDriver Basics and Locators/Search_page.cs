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
    public class SearchPage: BaseTest
    {
        private static string searchField = "//input[@id='searchterm']";
        private static string searchButton = "//*[@id='searchbutton']";
        private static string searchSpinner = "//*[@class='results-loading-ball']";
        private static string searchResultsTotal = "//span[@id='searchResultsTotalFound']";
        private static string actionButtonForTactic = "//div[@class='tacticAction tactic-action-btn'][1]";
        public static void DoSearch(IWebDriver driver, TimeSpan timeOut, string keywordSearch)
        {
            WaitForElementInvisibility(driver, timeOut, searchSpinner);
            driver.FindElement(By.XPath(searchField)).SendKeys(keywordSearch);
            driver.FindElement(By.XPath(searchButton)).Click();
        }

        public static string SearchTotalFound(IWebDriver driver, TimeSpan timeOut)
        {
            WaitForElementInvisibility(driver, timeOut, searchSpinner);
            return driver.FindElement(By.XPath(searchResultsTotal)).Text;
        }

        public static void ClickOnFirstReturnedItem(IWebDriver driver, TimeSpan timeOut)
        {
            WaitForElementInvisibility(driver, timeOut, searchSpinner);
            driver.FindElement(By.XPath(actionButtonForTactic)).Click();
        }
    }
}
