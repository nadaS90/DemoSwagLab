using DemoSwagLab.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwagLab.Pages
{
    public class CheckOutPage : PageBase
    {
        public CheckOutPage(IWebDriver driver) : base(driver)
        {
        }

        #region MyRegion
        //Locators :
        public const String FirstNameID = "first-name";
        public const String LastNameID = "last-name";
        public const String ZipCodeID = "postal-code";
        public const String ContinueBtnID = "continue";
        public const String OverViewDetailsID = "checkout_summary_container";
        public const String FinishBtnID = "finish";
        public const String SuccessMessageID = "h2.complete-header";


        #endregion

        public IWebElement FirstName => driver.FindElement(By.Id(FirstNameID));
        public IWebElement LastName => driver.FindElement(By.Id(LastNameID));
        public IWebElement ZipCode => driver.FindElement(By.Id(ZipCodeID));
        public IWebElement ContinueBtn => driver.FindElement(By.Id(ContinueBtnID));
        public IWebElement OverViewDetails => driver.FindElement(By.Id(OverViewDetailsID));
        public IWebElement FinishBtn => driver.FindElement(By.Id(FinishBtnID));
        public IWebElement SuccessMessage => driver.FindElement(By.CssSelector(SuccessMessageID));

        public string SuccessMsg => SuccessMessage.Text;


        public void FillTheCheckOutData(string fName, string lName, string code)
        {
            SendTxt(FirstName, fName);
            SendTxt(LastName, lName);
            SendTxt(ZipCode, code);
        }
        public void ClickContinueBtn()
        {
            ClickBtn(ContinueBtn);
        }

        public bool CheckOverViewDetailsDisplayed()
        {
            try
            {
                return OverViewDetails.Displayed;

            }

            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void FinishPlacingOrder()
        {
            ClickBtn(FinishBtn);
        }

        public bool DoesTheSuccessMessageDisplayed()
        {
            try
            {
                return SuccessMessage.Displayed;

            }

            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
