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
    [SetUpFixture]
    public class BaseTest
    {
        public static IWebDriver driver;
        public static TimeSpan timeOut;

        [OneTimeSetUp]
        public void OneceInit()
        {
            //timeOut = new TimeSpan(0, 0, 60);
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().SetPageLoadTimeout(timeOut);
        }

        [OneTimeTearDown]
        public void OneceCleanUp()
        {
            //driver.Close();
        }

        public static void WaitForElementInvisibility(IWebDriver driver, TimeSpan timeout, string XPath)
        {
            new WebDriverWait(driver, timeout).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(XPath)));
        }
        public static void WaitForElementVisibilityCSS(IWebDriver driver, TimeSpan timeout, string cssSelector)
        {
            new WebDriverWait(driver, timeout).Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cssSelector)));
        }
        public static void WaitForElementVisibilityXPath(IWebDriver driver, TimeSpan timeout, string XPath)
        {
            new WebDriverWait(driver, timeout).Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath)));
        }
        public static void WaitForElementToBeClickable(IWebDriver driver, TimeSpan timeout, string XPath)
        {
            new WebDriverWait(driver, timeout).Until(ExpectedConditions.ElementToBeClickable(By.XPath(XPath)));
        }
    }

    [TestFixture]
    class EndToEndTest: BaseTest
    {
        [Test]
        public void Test()
        { 
            TimeSpan timeOut = new TimeSpan(0, 0, 60);
            // IWebDriver driver = new FirefoxDriver();
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().SetPageLoadTimeout(timeOut);
            driver.Navigate().GoToUrl(Resource.Url);
            StartPage.EnterCredentials(driver);
            SelectAVendorPage.SelectTargetVendor(driver,Resource.Target_vendor);
            OldAdminPage.LoginAsUser(driver);
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            Thread.Sleep(10000);

            HomePage.Navigate_to_Search_page(driver);
            SearchPage.DoSearch(driver, timeOut, "parallel and nogif");
            Assert.AreEqual("(1)", SearchPage.SearchTotalFound(driver, timeOut));
            SearchPage.ClickOnFirstReturnedItem(driver,timeOut);
            CustomizationPage.ClickNextButton(driver, timeOut);
            CustomizationPage.ClickFinishButton(driver, timeOut);
            CustomizationPage.ClickAcceptAndContinueButton(driver,timeOut);
            CustomizationPage.EnterCostToRunValue(driver, timeOut, "1000");
            CustomizationPage.ClickPlaceOrderButton(driver, timeOut);

            Thread.Sleep(10000);

            Assert.AreEqual("Level 1 Approvers", driver.FindElement(By.XPath("//*[contains(@onclick,'ShowAuthGroup')]")).Text);
        }
    }
}
