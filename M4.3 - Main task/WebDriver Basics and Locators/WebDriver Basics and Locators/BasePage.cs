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
        public void OnceInit()
        {
            timeOut = new TimeSpan(0, 0, 120);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Manage().Timeouts().SetPageLoadTimeout(timeOut);
        }

        [OneTimeTearDown]
        public void OnceCleanUp()
        {
            driver.Close();
            driver.Dispose();
        }

        public static void WaitForElementInvisibility(IWebElement element)
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
                    return true;
                }
            });
        }

        public static void WaitForElementVisibility(IWebElement element)
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

        public class HighlightElement
        {
            public static void highlightElement(IWebElement element)
            {
                for (int i = 0; i < 5; i++)
                {
                    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", element, "color: yellow; border: 2px solid yellow;");
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", element, "");
                }
            }
        }
    }
}
