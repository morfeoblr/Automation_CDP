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
    public abstract class Browser
    {
        public abstract IWebDriver driver { get;  }
    }

    public class ChromeBrowser : Browser
    {
        public override IWebDriver driver
        {
            get
            {
                return new ChromeDriver();
            }
        }

    }
    class FirefoxBrowser: Browser
    {
        public override IWebDriver driver
        {
            get
            {
                return new FirefoxDriver();
            }
        }
    }
}
