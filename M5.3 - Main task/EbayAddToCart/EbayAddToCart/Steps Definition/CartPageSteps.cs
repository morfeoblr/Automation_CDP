using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbayAddToCart.Utils;
using EbayAddToCart.Page_Objects;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EbayAddToCart.Steps_Definition
{
    [Binding]
    public class CartPageSteps
    {
        [Then(@"I expect to be navigated to the Cart page")]
        public void ThenIExpectNavigationToTheCartPage()
        {
            CartPage cartPage = new CartPage();
            Assert.AreEqual(cartPage.title, cartPage.GetTitle(), "Page title is {0} instead of {1}", cartPage.GetTitle(), cartPage.title);
        }
        [Then(@"I expect to see selected item on the Cart page")]
        public void ThenIExpectToSeeSelectedItemOnTheCartPage()
        {
            CartPage cartPage = new CartPage();
            Assert.AreEqual(cartPage.CartItemText(), ScenarioContext.Current.Get<string>(TestData.ItemName), "Expected item name is {0} instead of {1}", ScenarioContext.Current.Get<string>(TestData.ItemName), cartPage.CartItemText());
        }
        [Then(@"I expect to see entered value of items on the Cart page")]
        public void ThenIExpectToSeeEnteredValueOfItemsOnTheCartPage()
        {
            CartPage cartPage = new CartPage();
            Assert.AreEqual(cartPage.GetQuantity(), ScenarioContext.Current.Get<int>(TestData.EnterQuantity), "Expected item name is {0} instead of {1}", ScenarioContext.Current.Get<int>(TestData.EnterQuantity), cartPage.GetQuantity());
        }
    }
}