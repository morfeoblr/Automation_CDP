using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace EbayAddToCart.Utils
{
    class Driver
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
                        case "chrome":
                            driver = new Lazy<IWebDriver>(() => new ChromeDriver());
                            break;
                        case "firefox":
                            driver = new Lazy<IWebDriver>(() => new FirefoxDriver());
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
