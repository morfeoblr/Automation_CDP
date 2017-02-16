using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriver_Basics_and_Locators
{
    public class CustomizationPage: BasePage
    {
        private const string NextButton = "//*[@id='studio_navigation_button_next' and @value='Next ']";
        private const string FinishButton = "//*[@id='studio_navigation_button_next' and @value='Finish']";
        private const string InlinePreview = "#studio_inlinepreview_jpeg>img";
        private const string AcceptAndContineButton = "//img[contains(@src,'AcceptAndContinueButton')]";
        private const string CostToRunInput = "//*[@id='ExtraField_{91873EC0-28D2-4135-9001-6B51EADE6B8C}']";
        private const string PlaceOrderButton = "//div[@id='LowerButtons']//*[@id='placeOrder']";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = NextButton)] private IWebElement nextButton;
        [FindsBy(How = How.XPath, Using = FinishButton)] private IWebElement finishButton;
        [FindsBy(How = How.XPath, Using = InlinePreview)] private IWebElement inlinePreview;
        [FindsBy(How = How.XPath, Using = AcceptAndContineButton)] private IWebElement acceptAndContineButton;
        [FindsBy(How = How.XPath, Using = CostToRunInput)] private IWebElement costToRunInput;
        [FindsBy(How = How.XPath, Using = PlaceOrderButton)] private IWebElement placeOrderButton;

        public CustomizationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickNextButton(IWebDriver driver)
        {
            WaitForElementVisibilityCSS(driver, inlinePreview);
            nextButton.Click();
        }
        public void ClickFinishButton(IWebDriver driver)
        {
            WaitForElementVisibilityCSS(driver, inlinePreview);
            finishButton.Click();
        }
        public void ClickAcceptAndContinueButton(IWebDriver driver)
        {
            WaitForElementToBeClickable(driver, acceptAndContineButton);
            acceptAndContineButton.Click();
        }
        public void EnterCostToRunValue(IWebDriver driver, string value)
        {
            WaitForElementVisibilityXPath(driver, costToRunInput);
            costToRunInput.SendKeys(value);
        }
        public void ClickPlaceOrderButton(IWebDriver driver)
        {
            WaitForElementVisibilityXPath(driver, placeOrderButton);
            placeOrderButton.Click();
        }
    }
}
