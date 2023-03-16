using DemoSwagLab.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;


namespace DemoSwagLab
{
    [Binding]
    public class ItemBrowsingTestsStep
    {
        private readonly HomePage _homeObject;
        private readonly ItemDetailsPage _itemDetails;

        public ItemBrowsingTestsStep(IWebDriver driver)
        {
            _homeObject = new HomePage(driver);
            _itemDetails = new ItemDetailsPage(driver);
        }

        [When(@"the user selects (.*) from the filter dropdown")]
        public void WhenTheUserSelectsOptionFromTheFilterDropdown(string option)
        {
            _homeObject.SelectOrderOfTheItems(option);
        }

        [Then(@"the results are sorted according to the (.*)")]
        public void ThenTheResultsAreSortedAccordingToTheOption(string option)
        {
            _homeObject.VerifyThatSortingByOrderAppliedCorrectly(option);
        }

        [When(@"The user clicks on an item")]
        public void WhenTheUserClicksOnAnItem()
        {
            _homeObject.NavigatesToItemDetailsPage(); 
        }

        [Then(@"The item information displayed")]
        public void ThenTheItemInformationDisplayed()
        {
            _itemDetails.DoesTheItemNameDisplayed();
            var actualItemName = _itemDetails.CorrectItemName;
            Assert.AreEqual("Sauce Labs Backpack", actualItemName, "The names are not matching");

        }

    }
}
