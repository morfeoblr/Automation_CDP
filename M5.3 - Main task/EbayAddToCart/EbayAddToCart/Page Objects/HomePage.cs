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
    public class HomePage: BasePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.Instance, this);
            this.title = "Electronics, Cars, Fashion, Collectibles, Coupons and More | eBay";
        }
        public void OpenUrl()
        {
            Driver.Instance.Navigate().GoToUrl(Utils.ConfigurationHelper.GetEnvURL);
        }
        public string GetTitle()
        {
            return Driver.Instance.Title;
        }


    }
}
