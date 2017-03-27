using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace WebDriver_Basics_and_Locators
{
    [TestFixture]
    public class TestScenarios: BaseTest
    {
        [Test]
        public void PlaceOrderWithLevel1Approvers()
        {
            StartPage startPage = new StartPage();
            startPage.OpenUrl();
            SelectAVendorPage selectAVendorPage = startPage.EnterCredentials();
            OldAdminPage oldAdminPage = selectAVendorPage.SelectTargetVendor();
            HomePage homePage = oldAdminPage.LoginAsUser();
            SearchPage searchPage = homePage.Navigate_to_Search_page();
            searchPage.DoSearch("parallel and nogif and automation");
            Assert.AreEqual("(1)", searchPage.SearchTotalFound(),"Search has returned more then 1 item.");
            CustomizationPage customizationPage = searchPage.ClickOnFirstReturnedItem();
            customizationPage.ClickNextButton();
            customizationPage.ClickFinishButton();
            customizationPage.ClickAcceptAndContinueButton();
            customizationPage.EnterCostToRunValue("1000");
            ConfirmationPage confirmationPage = customizationPage.ClickPlaceOrderButton();
            Assert.AreEqual("Level 1 Approvers", confirmationPage.GetGroupName(), "There is no Level 1 Approvers group shown on Confirmation page.");
            Assert.AreEqual(confirmationPage.title, confirmationPage.GetTitle(), "Page title is {0} instead of {1}", confirmationPage.title, confirmationPage.title);
        }

        [Test]
        public void HoverBubbleTest()
        {
            StartPage startPage = new StartPage();
            startPage.OpenUrl();
            SelectAVendorPage selectAVendorPage = startPage.EnterCredentials();
            OldAdminPage oldAdminPage = selectAVendorPage.SelectTargetVendor();
            HomePage homePage = oldAdminPage.LoginAsUser();
            SearchPage searchPage = homePage.Navigate_to_Search_page();
            searchPage.DoSearch("parallel and nogif and automation");
            Assert.AreEqual("(1)", searchPage.SearchTotalFound(), "Search has returned more then 1 item.");
            searchPage.HoverOverAction();
        }

        [Test]
        public void HighLightAndClickSearchMenuviaJS()
        {
            StartPage startPage = new StartPage();
            startPage.OpenUrl();
            SelectAVendorPage selectAVendorPage = startPage.EnterCredentials();
            OldAdminPage oldAdminPage = selectAVendorPage.SelectTargetVendor();
            HomePage homePage = oldAdminPage.LoginAsUser();
            homePage.HighLightSearch();
            SearchPage searchPage = homePage.JSClickOnSearch();
            Assert.AreEqual("Search", searchPage.title);
        }
    }
}
