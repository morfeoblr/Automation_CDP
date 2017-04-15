using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
// using EbayAddToCart.
using OpenQA.Selenium.Support.UI;
using System;

namespace EbayAddToCart.Utils
{
    public class BasePage: BaseTest
    {
        public string title { get; set; }
        public static void WaitForElementInvisibility(IWebElement element)
        {
            var wait = new WebDriverWait(Driver.Instance, timeOut);
            wait.Until(drv =>
            {
                try
                {
                    return element.Displayed == false;
                }
                catch
                {
                    return true;
                }
            });
        }
        public static void WaitForElementVisibility(IWebElement element)
        {
            var wait = new WebDriverWait(Driver.Instance, timeOut);
            wait.Until(drv =>
            {
                try
                {
                    return element.Displayed == true;
                }
                catch
                {
                    return false;
                }
            });
        }
    }
}
