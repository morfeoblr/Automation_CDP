using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver_Basics_and_Locators
{
    public class SelectAVendorPage
    {
        private static string _okButton = "//*[@id='btnOK']";
        public static void SelectTargetVendor(IWebDriver driver, string target)
        {
            string vendor = "//option[@value='" + target + "']";
            driver.FindElement(By.XPath(vendor)).Click();
            driver.FindElement(By.XPath(_okButton)).Click();
        }
    }
}
