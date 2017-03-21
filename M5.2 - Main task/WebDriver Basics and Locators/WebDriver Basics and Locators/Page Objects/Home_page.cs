using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebDriver_Basics_and_Locators.Page_Objects;

namespace WebDriver_Basics_and_Locators
{
    public class HomePage: PageDecorator
    {
        private const string SearchMenu = "//a[@href='/msc/Search']";

        [FindsBy(How = How.XPath, Using = SearchMenu)]
        private IWebElement searchMenu;

        public HomePage(InitialPage initialpage, IWebDriver driver) : base(initialpage.pagepath + " Home page ->", initialpage)
        {
            PageFactory.InitElements(driver, this);
        }

        public SearchPage Navigate_to_Search_page(HomePage homepage)
        {
            WaitForElementVisibility(searchMenu);
            searchMenu.Click();
            return new SearchPage(homepage, driver);
            //driver.Navigate().GoToUrl(Resource.Env_Url + "msc/Search");
        }

        public void HighLightSearch()
        {
            WaitForElementVisibility(searchMenu);
            HighlightElement.highlightElement(searchMenu);
        }

        public SearchPage JSClickOnSearch(HomePage homepage)
        {
            WaitForElementVisibility(searchMenu);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].click();", searchMenu);
            return new SearchPage(homepage, driver);
        }
    }
}
