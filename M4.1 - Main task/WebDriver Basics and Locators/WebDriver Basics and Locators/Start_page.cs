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
    public class StartPage: BaseTest
    {
        private static string _companyId = "//*[@id='txtCompanyID']";
        private static string _userId = "//*[@id='txtUserID']";
        private static string _password = "//*[@id='txtPassword']";
        private static string _loginButton = "//*[@id='btnLogin']";
        public static void EnterCredentials(IWebDriver driver)
        {
            driver.FindElement(By.XPath(_companyId)).SendKeys(Resource.Company_ID);
            driver.FindElement(By.XPath(_userId)).SendKeys(Resource.User_ID);
            driver.FindElement(By.XPath(_password)).SendKeys(Resource.Password);
            driver.FindElement(By.XPath(_loginButton)).Click();
        }
    }
}
