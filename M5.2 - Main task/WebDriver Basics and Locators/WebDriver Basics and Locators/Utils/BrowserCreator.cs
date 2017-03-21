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
    public abstract class BrowserCreator
    {
        public string Name { get; set; }
        public abstract Browser FactoryCreate();
    }
    public class ChromeCreator: BrowserCreator
    {
        public ChromeCreator()
        {
            this.Name = "Chrome";
        }
        public override Browser FactoryCreate()
        {
            return new ChromeBrowser();
        }
    }
    class FirefoxCreator : BrowserCreator
    {
        public FirefoxCreator()
        {
            this.Name = "Firefox";
        }
        public override Browser FactoryCreate()
        {
            return new FirefoxBrowser();
        }
    }
}
