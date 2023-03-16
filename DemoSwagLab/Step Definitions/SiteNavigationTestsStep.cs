using DemoSwagLab.Common_Locators;
using DemoSwagLab.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace DemoSwagLab
{
    [Binding]
    public class SiteNavigationTestsStep
    { 
       
           
            private readonly CommonLocators _commonObject;
          

            public SiteNavigationTestsStep(IWebDriver driver)
            {
               
                _commonObject = new CommonLocators(driver);
              
            }


            [When(@"the user clicks on the burger menu")]
        public void WhenTheUserClicksOnTheBurgerMenu()
        {
            _commonObject.SelectMenuOption();
        }

        [When(@"the user selects About")]
        public void WhenTheUserSelectsAbout()
        {
            _commonObject.ClickOnAboutLink();
        }

        [Then(@"the user will be directed to SauceLabs website")]
        public void ThenTheUserWillBeDirectedToSauceLabsWebsite()
        {
            _commonObject.GetNewTabDetails();
        }
    }
}
