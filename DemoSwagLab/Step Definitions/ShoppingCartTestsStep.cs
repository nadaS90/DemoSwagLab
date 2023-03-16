using DemoSwagLab.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using DemoSwagLab.Common_Locators;
using DemoSwagLab.Data;

namespace DemoSwagLab
{
    [Binding]
    public class ShoppingCartTestsStep
    {
        private readonly HomePage _homeObject;
        private readonly ItemDetailsPage _itemDetails;
        private readonly CommonLocators _commonObject;
        private readonly CartPage _cartObject;
        private readonly CheckOutPage _checkOut;

        public ShoppingCartTestsStep(IWebDriver driver)
        {
            _homeObject = new HomePage(driver);
            _itemDetails = new ItemDetailsPage(driver);
            _commonObject = new CommonLocators(driver);
            _cartObject = new CartPage(driver);
            _checkOut = new CheckOutPage(driver);   

        }



        [When(@"the user adds items to the cart")]
        public void WhenTheUserAddsItemsToTheCart()
        {
            _homeObject.AddItemsToTheCart();
        }

        [Then(@"the item will be added to the cart")]
        public void ThenTheItemWillBeAddedToTheCart()
        {
            _cartObject.CheckThatCartIsNotEmptyAfterAddingItems();

        }

        [When(@"the user removes an item to the cart")]
        public void WhenTheUserRemovesAnItemToTheCart()
        {
            _cartObject.ClickOnRemoveBtn();
        }

        [Then(@"the item will be removed to the cart")]
        public void ThenTheItemWillBeRemovedToTheCart()
        {
            _cartObject.CheckItemIsNotDisplayed();
        }

        [When(@"the user navigates to the Cart page")]
        public void WhenTheUserNavigatesToTheCartPage()
        {
            _commonObject.NavigatesToCart();
        }

        [When(@"the user clicks on checkout button")]
        public void WhenTheUserClicksOnCheckoutButton()
        {
            _cartObject.ClickOnCheckOutBtn();   
        }

        [When(@"the user fills the mandatory fields")]
        public void WhenTheUserFillsTheMandatoryFields()
        {
            _checkOut.FillTheCheckOutData(Constants.FirstName, Constants.LastName, Constants.ZipCode);
        }

        [When(@"the user clicks on continue button")]
        public void WhenTheUserClicksOnContinueButton()
        {
            _checkOut.ClickContinueBtn();
        }

        [Then(@"the overview details will be displayed")]
        public void ThenTheOverviewDetailsWillBeDisplayed()
        {
            _checkOut.CheckOverViewDetailsDisplayed();
        }

        [When(@"the user clicks on finish button")]
        public void WhenTheUserClicksOnFinishButton()
        {
            _checkOut.FinishPlacingOrder();
        }

        [Then(@"the item is purchased and success message appear")]
        public void ThenTheItemIsPurchasedAndSuccessMessageAppear()
        {
            _checkOut.DoesTheSuccessMessageDisplayed();
            var actualSuccessMessage = _checkOut.SuccessMsg;
            Assert.AreEqual("Thank you for your order!", actualSuccessMessage, "Success message is not displayed correctly ");

        }
    }
}
