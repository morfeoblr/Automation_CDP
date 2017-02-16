using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;


namespace WebDriver_Basics_and_Locators
{
    public class StartPage: BasePage
    {
        private const string CompanyId = "//*[@id='txtCompanyID']";
        private const string UserId = "//*[@id='txtUserID']";
        private const string Password = "//*[@id='txtPassword']";
        private const string LoginButton = "//*[@id='btnLogin']";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = CompanyId)] private IWebElement companyId;
        [FindsBy(How = How.XPath, Using = UserId)] private IWebElement userId;
        [FindsBy(How = How.XPath, Using = Password)] private IWebElement password;
        [FindsBy(How = How.XPath, Using = LoginButton)] private IWebElement loginButton;

        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public SelectAVendorPage EnterCredentials()
        {
            companyId.SendKeys(Resource.Company_ID);
            userId.SendKeys(Resource.User_ID);
            password.SendKeys(Resource.Password);
            loginButton.Click();
            return new SelectAVendorPage(driver);
        }
    }
}
