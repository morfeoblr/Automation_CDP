using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbayAddToCart.Utils;
using EbayAddToCart.Page_Objects;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace EbayAddToCart.Steps_Definition
{
    [Binding]
    public class SectionPageSteps
    {
        [Given(@"I have navigated to Camera page")]
        public void GivenIHaveNavigatedToCameraPage(Table table)
        {
            SectionPage sectionPage = new SectionPage();
            sectionPage.OpenItemsUrl(table.Rows[0].Values.First());
        }

        [Given(@"I have navigated to page with url '(.*)'")]
        public void GivenIHaveNavigatedToSectionPageWithUrl(string url)
        {
            SectionPage itemPage = new SectionPage();
            itemPage.OpenItemsUrl(url);
        }

        [When(@"I click on first returned item")]
        public void GivenIClickOnFirstReturnedItem()
        {
            SectionPage sectionPage = new SectionPage();
            ItemPage itemPage = sectionPage.OpenFirstItemPage();
        }
    }
}
