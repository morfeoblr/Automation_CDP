using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace WebDriver_Basics_and_Locators.Utils
{
    public sealed class Driver
    {
        private static Lazy<IWebDriver> driver;

        public static IWebDriver Instance { get { return GetDriver; } }

        private Driver()
        {
        }
        private static IWebDriver GetDriver
        {
            get
            {
                if (driver == null)
                {
                    switch (ConfigurationHelper.GetDriver.ToLower())
                    {
                        case "firefox":
                            BrowserCreator creator1 = new FirefoxCreator();
                            Browser browser1 = creator1.FactoryCreate();
                            driver = new Lazy<IWebDriver>(() => browser1.driver);
                            break;
                        case "chrome":
                            BrowserCreator creator2 = new ChromeCreator();
                            Browser browser2 = creator2.FactoryCreate();
                            driver = new Lazy<IWebDriver>(() => browser2.driver);
                            break;
                        default:
                            throw new Exception("Wrong browser is specified in app.config file!");
                            break;
                    }
                }
                return driver.Value;
            }
            set { }
        }
    }
}
