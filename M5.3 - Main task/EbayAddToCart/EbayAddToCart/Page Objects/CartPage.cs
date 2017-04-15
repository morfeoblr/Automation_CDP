using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbayAddToCart.Utils;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace EbayAddToCart.Page_Objects
{
    public class CartPage: BasePage
    {
        private const string CartItemNameText = "div[class='ff-ds3 fs16 mb5 fw-n sci-itmttl'] a";
        private const string CartItemQuantity = "div[class='fl col_100p clearfix'] input[role='textbox']";


        [FindsBy(How = How.CssSelector, Using = CartItemNameText)]
        private IWebElement cartItemNameText;

        [FindsBy(How = How.CssSelector, Using = CartItemQuantity)]
        private IWebElement cartItemQuantity;

        public CartPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
            this.title = "Ваша корзина";
        }
        public string GetTitle()
        {
            return Driver.Instance.Title;
        }
        public string CartItemText()
        {
            return cartItemNameText.Text;
        }
        public int GetQuantity()
        {
            string quantity = cartItemQuantity.GetAttribute("value").ToString();
            return Convert.ToInt32(quantity);
        }
    }
}
