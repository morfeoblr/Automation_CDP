using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using WebDriver_Basics_and_Locators.Utils;
using WebDriver_Basics_and_Locators.Utils;

namespace WebDriver_Basics_and_Locators
{
    public class StartPage : BaseTest
    {
        private const string CompanyId = "//*[@id='txtCompanyID']";
        private const string UserId = "//*[@id='txtUserID']";
        private const string Password = "//*[@id='txtPassword']";
        private const string LoginButton = "//*[@id='btnLogin']";

        [FindsBy(How = How.XPath, Using = CompanyId)]
        private IWebElement companyId;

        [FindsBy(How = How.XPath, Using = UserId)]
        private IWebElement userId;

        [FindsBy(How = How.XPath, Using = Password)]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = LoginButton)]
        private IWebElement loginButton;

        public StartPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public void OpenUrl()
        {
            Driver.Instance.Navigate().GoToUrl(Utils.ConfigurationHelper.GetEnvURL);
        }

        public SelectAVendorPage EnterCredentials()
        {
            //   GlobalUser globalUser = new GlobalUser();
            companyId.SendKeys(GlobalUser.getUser.CompanyID);
            userId.SendKeys(GlobalUser.getUser.UserID);
            password.SendKeys(GlobalUser.getUser.Password);
            loginButton.Click();
            return new SelectAVendorPage();
        }
    }
}
