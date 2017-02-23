using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebDriver_Basics_and_Locators
{
    public class HomePage: BasePage
    {
        private const string SearchMenu = "//a[@href='/msc/Search']";

        [FindsBy(How = How.XPath, Using = SearchMenu)]
        private IWebElement searchMenu;

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public SearchPage Navigate_to_Search_page()
        {
            WaitForElementVisibility(searchMenu);
            searchMenu.Click();
            return new SearchPage(driver);
            //driver.Navigate().GoToUrl(Resource.Env_Url + "msc/Search");
        }
    }
}
