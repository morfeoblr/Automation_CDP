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
        private const string CostToRunInput = "//*[@id='ExtraField_{B861D482-0F67-453D-90DF-59CB47E647DC}']";
        private const string PlaceOrderButton = "//div[@id='LowerButtons']//*[@id='placeOrder']";

        [FindsBy(How = How.XPath, Using = NextButton)]
        private IWebElement nextButton;

        [FindsBy(How = How.XPath, Using = FinishButton)]
        private IWebElement finishButton;

        [FindsBy(How = How.CssSelector, Using = InlinePreview)]
        private IWebElement inlinePreview;

        [FindsBy(How = How.XPath, Using = AcceptAndContineButton)]
        private IWebElement acceptAndContineButton;

        [FindsBy(How = How.XPath, Using = CostToRunInput)]
        private IWebElement costToRunInput;

        [FindsBy(How = How.XPath, Using = PlaceOrderButton)]
        private IWebElement placeOrderButton;

        public CustomizationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void ClickNextButton()
        {
            WaitForElementVisibility(inlinePreview);
            nextButton.Click();
        }
        public void ClickFinishButton()
        {
            WaitForElementVisibility(inlinePreview);
            finishButton.Click();
        }
        public void ClickAcceptAndContinueButton()
        {
            WaitForElementVisibility(acceptAndContineButton);
            acceptAndContineButton.Click();
        }
        public void EnterCostToRunValue(string value)
        {
            WaitForElementVisibility(costToRunInput);
            costToRunInput.SendKeys(value);
        }
        public ConfirmationPage ClickPlaceOrderButton()
        {
            WaitForElementVisibility(placeOrderButton);
            placeOrderButton.Click();
            return new ConfirmationPage(driver);
        }
    }
}
