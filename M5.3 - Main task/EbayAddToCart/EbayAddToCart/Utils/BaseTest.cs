using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
//using EbayAddToCart.Tests;
using OpenQA.Selenium.Support.UI;

namespace EbayAddToCart.Utils
{
    public class BaseTest
    {
        public static TimeSpan timeOut;

        [BeforeScenario]
        public void OnceInit()
        {
            timeOut = new TimeSpan(0, 0, 120);
           // Driver.Instance.Manage().Window.Maximize();
            Driver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            Driver.Instance.Manage().Timeouts().SetPageLoadTimeout(timeOut);
        }

        [AfterScenario]
        public void OnceCleanUp()
        {
            Driver.Instance.Close();
            Driver.Instance.Dispose();
        }
    }
}
