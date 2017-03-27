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
using WebDriver_Basics_and_Locators.Business_objects;

namespace WebDriver_Basics_and_Locators
{
    public class OldAdminPage : BaseTest
    {
        private const string Division = "//*[@id='ctl00_ctl00_cell3row2']/a";
        private const string VendorUsers = "//a[@class='Level2NavigationNotSelectedText'][1]";
        private const string AuthentificationIdInput = "//*[@id='ctl01_txtUserAccessID']";
        private const string SearchButton = "//*[@id='ctl01_btnSearch']";
        private const string LoginLink = "//a[contains(@onclick,'alexb')][1]";

        [FindsBy(How = How.XPath, Using = Division)]
        private IWebElement division;

        [FindsBy(How = How.XPath, Using = VendorUsers)]
        private IWebElement vendorUsers;

        [FindsBy(How = How.XPath, Using = AuthentificationIdInput)]
        private IWebElement authentificationIdInput;

        [FindsBy(How = How.XPath, Using = SearchButton)]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = LoginLink)]
        private IWebElement loginLink;

        public OldAdminPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public HomePage LoginAsUser()
        {
            division.Click();
            vendorUsers.Click();
            //PortalUser portaluser = new PortalUser();
            //authentificationIdInput.SendKeys(portaluser.AuthID);
            User user = new MSUser();
            user = new ToAdminUser(user);
            authentificationIdInput.SendKeys(user.AuthID);
            searchButton.Click();
            loginLink.Click();
            Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());
            return new HomePage();
        }
    }
}
