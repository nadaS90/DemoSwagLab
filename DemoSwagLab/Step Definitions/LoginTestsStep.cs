using DemoSwagLab.Hook_Initialization;
using DemoSwagLab.Pages;
using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Constants = DemoSwagLab.Data.Constants;


namespace DemoSwagLab
{
    [Binding]
    public class LoginTestsStep
    {
        LoginPage _loginObject;
        HomePage _homeObject;

        public LoginTestsStep(IWebDriver driver)
        {
            _loginObject = new LoginPage(Hooks.driver);

            _homeObject = new HomePage(Hooks.driver);
        }

        [Given(@"User on the log in page")]
        public void GivenUserOnTheLogInPage()
        {
            _loginObject.GetCurrentUrl();
        }

        [When(@"User enter valid username and password")]
        public void WhenUserEnterValidUsernameAndPassword()
        {
            _loginObject.UserEnterEmailAndPassword(Constants.StandardUser, Constants.Password);
        }

        [When(@"Press Login")]
        public void WhenPressLogin()
        {
            _loginObject.UserLogIn();
        }

        [Then(@"The home page should be displayed")]
        public void ThenTheHomePageShouldBeDisplayed()
        {
            var expectedTitle = _homeObject.GetPageTitle();
            Assert.AreEqual("Swag Labs", expectedTitle, "Title is not correct ");
        }

        [When(@"User enter locked username")]
        public void WhenUserEnterLockedUsername()
        {
            _loginObject.UserEnterEmailAndPassword(Constants.locked_out_user, Constants.Password);
        }

        [Then(@"Error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            _loginObject.DoesTheLoginErrorMessageDisplayed();
            var actualErrorMessage = _loginObject.LoginErrorMessage;
            Assert.AreEqual("Epic sadface: Sorry, this user has been locked out.", actualErrorMessage, "error message is not displayed correctly ");
        }

        [When(@"User enter problem username and password")]
        public void WhenUserEnterProblemUsernameAndPassword()
        {
            _loginObject.UserEnterEmailAndPassword(Constants.problem_user, Constants.Password);
        }

        [Then(@"The home page should be displayed with issues")]
        public void ThenTheHomePageShouldBeDisplayedWithIssues()
        {
            _homeObject.DoesTheItemsPhotoDisplayed();
            var actualItemPgoto = _homeObject.ItemPhotoDetails;
            Assert.AreNotEqual("src = '/static/media/sauce-backpack-1200x1500.0a0b85a3.jpg'", actualItemPgoto, "Item photo is matching the item name");
        }
    }
}
