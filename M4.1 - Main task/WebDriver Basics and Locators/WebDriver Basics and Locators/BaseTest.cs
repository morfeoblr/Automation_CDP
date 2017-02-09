using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriver_Basics_and_Locators
{
    public class BaseTest
    {
        public static TimeSpan timeOut;
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void OneceInit()
        {
            timeOut = new TimeSpan(0, 0, 120);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().SetPageLoadTimeout(timeOut);
        }

        [OneTimeTearDown]
        public void OneceCleanUp()
        {
            driver.Close();
            driver.Dispose();
        }

        public static void WaitForElementInvisibility(IWebDriver driver, string XPath)
        {
            new WebDriverWait(driver, timeOut).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(XPath)));
        }
        public static void WaitForElementVisibilityCSS(IWebDriver driver, string cssSelector)
        {
            new WebDriverWait(driver, timeOut).Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cssSelector)));
        }
        public static void WaitForElementVisibilityXPath(IWebDriver driver, string XPath)
        {
            new WebDriverWait(driver, timeOut).Until(ExpectedConditions.ElementIsVisible(By.XPath(XPath)));
        }
        public static void WaitForElementToBeClickable(IWebDriver driver, string XPath)
        {
            new WebDriverWait(driver, timeOut).Until(ExpectedConditions.ElementToBeClickable(By.XPath(XPath)));
        }
    }
}
