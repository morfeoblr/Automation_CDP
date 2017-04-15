using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbayAddToCart.Utils;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace EbayAddToCart.Page_Objects
{
    public class SectionPage: BasePage
    {
        private const string FirstItem = ".widget-wrapper";

        [FindsBy(How = How.CssSelector, Using = FirstItem)]
        private IWebElement firstItem;

        public SectionPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }
        public void OpenItemsUrl(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
        }
        public ItemPage OpenFirstItemPage()
        {
            firstItem.Click();
            return new ItemPage();
        }
    }
}
