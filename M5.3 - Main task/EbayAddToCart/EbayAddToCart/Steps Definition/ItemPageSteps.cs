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
    public class ItemPageSteps
    {
        [When(@"I click on Add to Cart button")]
        public void WhenIClickOnAddToCartButton()
        {
            ItemPage itemPage = new ItemPage();
            ScenarioContext.Current.Set(itemPage.ItemName(), TestData.ItemName);
            ScenarioContext.Current.Set(Driver.Instance.Url, TestData.ItemPageUrl);
            CartPage cartPage = itemPage.AddToCartAction();
        }
        [When(@"I enter non-defailt quantity of items '(.*)'")]
        public void WhenIEnterNon_DefailtQuantityOfItems(int p0)
        {
            ItemPage itemPage = new ItemPage();
            itemPage.EnterQuantity(p0);
            ScenarioContext.Current.Set(p0, TestData.EnterQuantity);
        }
        [Then(@"I expect to see red hint under count field")]
        public void ThenIExpectStillStayOnTheItemPageAndSeeRedHintUnderCountField()
        {
            ItemPage itemPage = new ItemPage();
            Assert.AreEqual(itemPage.QuantityErrorMessageText(), itemPage.quantityExpectedErrorMessageText, "Page title is {0} instead of {1}", itemPage.QuantityErrorMessageText(), itemPage.quantityExpectedErrorMessageText);
        }
        [When(@"I navigate to just added Item page")]
        public void WhenINavigateToJustAddedItemPage()
        {
            Driver.Instance.Navigate().GoToUrl(ScenarioContext.Current.Get<string>(TestData.ItemPageUrl));
        }
        [Then(@"I expect to see text saying that this item is already added to the Cart page")]
        public void ThenIExpectToNotSeeAddToCartButtonOnTheItemPage()
        {
            ItemPage itemPage = new ItemPage();
            Assert.AreEqual(itemPage.GetLabelOfAlreadyAddedToCartItem(), itemPage.alreadyAddedToCartLabelText, "Page title is {0} instead of {1}", itemPage.GetLabelOfAlreadyAddedToCartItem(), itemPage.alreadyAddedToCartLabelText);
        }
    }
}
