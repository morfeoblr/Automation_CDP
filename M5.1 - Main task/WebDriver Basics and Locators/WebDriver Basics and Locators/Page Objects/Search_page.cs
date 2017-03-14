using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebDriver_Basics_and_Locators
{
    public class SearchPage: BasePage
    {
        private const string SearchField = "//input[@id='searchterm']";
        private const string SearchButton = "//*[@id='searchbutton']";
        private const string SearchSpinner = "//*[@class='results-loading-ball']";
        private const string SearchResultsTotal = "//span[@id='searchResultsTotalFound']";
        private const string ActionButtonForTactic = "//div[@class='tacticAction tactic-action-btn'][1]";
        private const string ItemThumbnail = "//img[@title='Parallel noGif PDF Download Template Unit price']";
        private const string HoverBubbleCustomizeButton = "//span[text()='Customize']";
        private const string ItemThumbnailCSS = "#thumb_e7c0b49d-8840-4452-890c-a73601486f37";
        private const string ContentLinkName = "//div[@class='nameLink']//span[@class='ellipsis_text']";
        private const string SearchArea = "//ul[@id='searchResultsItemContainer']";

        [FindsBy(How = How.XPath, Using = SearchField)]
        private IWebElement searchField;

        [FindsBy(How = How.XPath, Using = SearchButton)]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = SearchSpinner)]
        private IWebElement searchSpinner;

        [FindsBy(How = How.XPath, Using = SearchResultsTotal)]
        private IWebElement searchResultsTotal;

        [FindsBy(How = How.XPath, Using = ActionButtonForTactic)]
        private IWebElement actionButtonForTactic;

        [FindsBy(How = How.XPath, Using = ItemThumbnail)]
        private IWebElement itemThumbnail;

        [FindsBy(How = How.XPath, Using = HoverBubbleCustomizeButton)]
        private IWebElement hoverBubbleCustomizeButton;

        [FindsBy(How = How.CssSelector, Using = ItemThumbnailCSS)]
        private IWebElement itemThumbnailCSS;

        [FindsBy(How = How.CssSelector, Using = ContentLinkName)]
        private IWebElement contentLinkName;

        [FindsBy(How = How.XPath, Using = SearchArea)]
        private IWebElement searchArea;

        public SearchPage(IWebDriver driver)
        {
            this.title = "Search";
            PageFactory.InitElements(driver,this);
        }

        public void DoSearch(string keywordSearch)
        {
     //       WaitForElementInvisibility(driver, searchSpinner);
            searchField.SendKeys(keywordSearch);
            searchButton.Click();
        }

        public string SearchTotalFound()
        {
            WaitForElementInvisibility(searchSpinner);
            return searchResultsTotal.Text;
        }

        public CustomizationPage ClickOnFirstReturnedItem()
        {
    //        WaitForElementInvisibility(driver, searchSpinner);
            actionButtonForTactic.Click();
            return new CustomizationPage(driver);
        }

        public void HoverOverAction()
        {
            Actions hover = new Actions(driver);
            hover.MoveToElement(itemThumbnailCSS).Build().Perform();
            WaitForElementVisibility(hoverBubbleCustomizeButton);
            hover.Click(hoverBubbleCustomizeButton).Build().Perform();
        }
    }
}
