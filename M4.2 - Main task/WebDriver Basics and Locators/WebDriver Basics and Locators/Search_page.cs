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
    public class SearchPage: BasePage
    {
        private const string SearchField = "//input[@id='searchterm']";
        private const string SearchButton = "//*[@id='searchbutton']";
        private const string SearchSpinner = "//*[@class='results-loading-ball']";
        private const string SearchResultsTotal = "//span[@id='searchResultsTotalFound']";
        private const string ActionButtonForTactic = "//div[@class='tacticAction tactic-action-btn'][1]";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = SearchField)] private IWebElement searchField;
        [FindsBy(How = How.XPath, Using = SearchButton)] private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = SearchSpinner)] private IWebElement searchSpinner;
        [FindsBy(How = How.XPath, Using = SearchResultsTotal)] private IWebElement searchResultsTotal;
        [FindsBy(How = How.XPath, Using = ActionButtonForTactic)] private IWebElement actionButtonForTactic;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void DoSearch(string keywordSearch)
        {
            WaitForElementInvisibility(driver, searchSpinner);
            searchField.SendKeys(keywordSearch);
            searchButton.Click();
        }

        public string SearchTotalFound()
        {
            WaitForElementInvisibility(driver, searchSpinner);
            return searchResultsTotal.Text;
        }

        public CustomizationPage ClickOnFirstReturnedItem()
        {
            WaitForElementInvisibility(driver, searchSpinner);
            actionButtonForTactic.Click();
            return new CustomizationPage(driver);
        }
    }
}
