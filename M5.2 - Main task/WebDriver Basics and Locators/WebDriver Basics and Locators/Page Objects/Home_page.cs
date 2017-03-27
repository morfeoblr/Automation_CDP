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
using WebDriver_Basics_and_Locators.Utils;

namespace WebDriver_Basics_and_Locators
{
    public class HomePage : BaseTest
    {
        private const string SearchMenu = "//a[@href='/msc/Search']";

        [FindsBy(How = How.XPath, Using = SearchMenu)]
        private IWebElement searchMenu;

        public HomePage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public SearchPage Navigate_to_Search_page()
        {
            WaitForElementVisibility(searchMenu);
            searchMenu.Click();
            return new SearchPage();
            //driver.Navigate().GoToUrl(Resource.Env_Url + "msc/Search");
        }

        public void HighLightSearch()
        {
            WaitForElementVisibility(searchMenu);
            HighlightElement.highlightElement(searchMenu);
        }

        public SearchPage JSClickOnSearch()
        {
            WaitForElementVisibility(searchMenu);
            IJavaScriptExecutor js = Driver.Instance as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].click();", searchMenu);
            return new SearchPage();
        }
    }
}
