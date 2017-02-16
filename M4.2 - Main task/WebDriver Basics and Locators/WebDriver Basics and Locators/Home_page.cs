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
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = SearchMenu)] private IWebElement searchMenu;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public SearchPage Navigate_to_Search_page()
        {
            WaitForElementVisibilityXPath(driver, searchMenu);
            searchMenu.Click();
            return new SearchPage(driver);

            //driver.Navigate().GoToUrl(Resource.Env_Url + "msc/Search");
        }
    }
}
