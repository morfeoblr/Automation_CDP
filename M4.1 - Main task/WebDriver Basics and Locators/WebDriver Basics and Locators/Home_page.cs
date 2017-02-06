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
    public class HomePage: BaseTest
    {
        //private static string searchMenu = "//a[@href='/msc/Search']";
        public static void Navigate_to_Search_page(IWebDriver driver)
        {
            //driver.FindElement(By.XPath(searchMenu)).Click();
            driver.Navigate().GoToUrl(Resource.Env_Url + "msc/Search");
        }
    }
}
