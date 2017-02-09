using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver_Basics_and_Locators
{
    public class CustomizationPage: BaseTest
    {
        private static string nextButton = "//*[@id='studio_navigation_button_next' and @value='Next ']";
        private static string finishButton = "//*[@id='studio_navigation_button_next' and @value='Finish']";
        private static string inlinePreview = "#studio_inlinepreview_jpeg>img";
        private static string acceptAndContineButton = "//img[contains(@src,'AcceptAndContinueButton')]";
        private static string costToRunInput = "//*[@id='" + Resource.Id_of_Cost_to_Run + "']";
        private static string placeOrderButton = "//div[@id='LowerButtons']//*[@id='placeOrder']";
        public static void ClickNextButton(IWebDriver driver)
        {
            WaitForElementVisibilityCSS(driver, inlinePreview);
            driver.FindElement(By.XPath(nextButton)).Click();
        }
        public static void ClickFinishButton(IWebDriver driver)
        {
            WaitForElementVisibilityCSS(driver, inlinePreview);
            driver.FindElement(By.XPath(finishButton)).Click();
        }
        public static void ClickAcceptAndContinueButton(IWebDriver driver)
        {
            WaitForElementToBeClickable(driver, acceptAndContineButton);
            driver.FindElement(By.XPath(acceptAndContineButton)).Click();
        }
        public static void EnterCostToRunValue(IWebDriver driver, string value)
        {
            WaitForElementVisibilityXPath(driver, costToRunInput);
            driver.FindElement(By.XPath(costToRunInput)).SendKeys(value);
        }
        public static void ClickPlaceOrderButton(IWebDriver driver)
        {
            WaitForElementVisibilityXPath(driver, placeOrderButton);
            driver.FindElement(By.XPath(placeOrderButton)).Click();
        }
    }
}
