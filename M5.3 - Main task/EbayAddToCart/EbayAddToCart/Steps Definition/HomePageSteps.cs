using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbayAddToCart.Utils;
using EbayAddToCart.Page_Objects;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EbayAddToCart.Steps_Definition
{
    [Binding]
    public class HomePageSteps: BaseTest
    {
        [Given(@"I have logged into the application")]
        public void GivenIHaveLoggedIntoTheApplication()
        {
            HomePage homePage = new HomePage();
            homePage.OpenUrl();
        }

        [Then(@"the page title should be proper")]
        public void ThenThePageTitleShouldBeProper()
        {
            HomePage homePage = new HomePage();
            Assert.AreEqual(homePage.title, homePage.GetTitle(), "Page title is {0} instead of {1}", homePage.GetTitle(), homePage.title);
        }
    }
}
