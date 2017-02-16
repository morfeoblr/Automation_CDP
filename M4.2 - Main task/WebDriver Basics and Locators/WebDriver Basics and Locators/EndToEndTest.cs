using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriver_Basics_and_Locators
{
    [TestFixture]
    public class TestScenarios: BasePage
    {
        [Test]
        public void PlaceOrderWithLevel1Approvers()
        {
            driver.Navigate().GoToUrl(Resource.Url);
            StartPage.EnterCredentials(driver);
            SelectAVendorPage.SelectTargetVendor(driver,Resource.Target_vendor);
            OldAdminPage.LoginAsUser(driver);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            HomePage.Navigate_to_Search_page(driver);
            SearchPage.DoSearch(driver, "parallel and nogif");
            Assert.AreEqual("(1)", SearchPage.SearchTotalFound(driver),"Search has returned more then 1 item.");
            SearchPage.ClickOnFirstReturnedItem(driver);
            CustomizationPage.ClickNextButton(driver);
            CustomizationPage.ClickFinishButton(driver);
            CustomizationPage.ClickAcceptAndContinueButton(driver);
            CustomizationPage.EnterCostToRunValue(driver, "1000");
            CustomizationPage.ClickPlaceOrderButton(driver);
            Assert.AreEqual("Level 1 Approvers", ConfirmationPage.GetGroupName(driver), "There is no Level 1 Approvers group shown on Confirmation page.");
        }
    }
}
