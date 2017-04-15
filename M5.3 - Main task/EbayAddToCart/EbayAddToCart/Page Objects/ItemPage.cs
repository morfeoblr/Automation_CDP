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
    public class ItemPage: BasePage
    {
        private const string AddToCartButton = "#isCartBtn_btn";
        private const string ItemNameText = "h1[id='itemTitle']";
        private const string QuantityInputField = "input[class='qtyInput']";
        private const string QuantityErrorMessage = "#qtyErrMsg div";
        private const string AlreadyAddedToCart = "#atcLnk";

        [FindsBy(How = How.CssSelector, Using = AddToCartButton)]
        private IWebElement addToCartButton;

        [FindsBy(How = How.CssSelector, Using = ItemNameText)]
        private IWebElement itemNameText;

        [FindsBy(How = How.CssSelector, Using = QuantityInputField)]
        private IWebElement quantityInputField;

        [FindsBy(How = How.CssSelector, Using = QuantityErrorMessage)]
        private IWebElement quantityErrorMessage;

        [FindsBy(How = How.CssSelector, Using = AlreadyAddedToCart)]
        private IWebElement alreadyAddedToCart;

        public string quantityExpectedErrorMessageText { get; set; }
        public string alreadyAddedToCartLabelText { get; set; }

        public ItemPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
            this.quantityExpectedErrorMessageText = "Введите количество, равное 1, или большее количество";
            this.alreadyAddedToCartLabelText = "Добавлено в вашу корзину";
        }

        public string ItemName()
        {
            return itemNameText.Text;
        }

        public string QuantityErrorMessageText()
        {
            return quantityErrorMessage.Text;
        }

        public string GetLabelOfAlreadyAddedToCartItem()
        {
            return alreadyAddedToCart.Text;
        }

        public CartPage AddToCartAction()
        {
            addToCartButton.Click();
            return new CartPage();
        }
        public void EnterQuantity(int quantity)
        {
            quantityInputField.Clear();
            quantityInputField.SendKeys(quantity.ToString());
        }
    }
}
