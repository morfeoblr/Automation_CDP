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
    public class BasePage
    {
        public static TimeSpan timeOut;
        public static IWebDriver driver;

        public string title { get; set; }

        [OneTimeSetUp]
        public void OneceInit()
        {
            timeOut = new TimeSpan(0, 0, 120);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.Manage().Timeouts().SetPageLoadTimeout(timeOut);
        }

        [OneTimeTearDown]
        public void OneceCleanUp()
        {
            driver.Close();
            driver.Dispose();
        }

        public static void WaitForElementInvisibility(IWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, timeOut);
            wait.Until(drv =>
            {
                try
                {
                    return element.Displayed == false;
                }
                catch
                {
                    return false;
                }
            } );
        }

        public static void WaitForElementVisibilityCSS(IWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, timeOut);
            wait.Until(drv =>
            {
                try
                {
                    return element.Displayed == true;
                }
                catch
                {
                    return false;
                }
            });
        }

        public static void WaitForElementVisibilityXPath(IWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, timeOut);
            wait.Until(drv =>
            {
                try
                {
                    return element.Displayed == true;
                }
                catch
                {
                    return false;
                }
            });
        }

        public static void WaitForElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, timeOut);
            wait.Until(drv =>
            {
                try
                {
                    return element.Displayed == true;
                }
                catch
                {
                    return false;
                }
            });
        }
    }
}
