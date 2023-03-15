using DemoSwagLab.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwagLab.Pages
{
    public class LoginPage : PageBase
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        #region MyRegion
        //Locators :
        public const String UserNameID = "user-name";
        public const String PasswordID = "password";
        public const String LoginBtnID = "//input[@id='login-button']";
        public const String ErrorMsgID = "//div[@class='error-message-container error']";
        #endregion

        IWebElement UserNAmeTextBox => driver.FindElement(By.Id(UserNameID));
        IWebElement PasswordTextField => driver.FindElement(By.Id(PasswordID));
        IWebElement LoginBtn => driver.FindElement(By.XPath(LoginBtnID));
        public IWebElement ErrorMsg => driver.FindElement(By.XPath(ErrorMsgID));

        public string LoginErrorMessage => ErrorMsg.Text;

        public void UserEnterEmailAndPassword(String UserName, String Password)
        {
            SendTxt(UserNAmeTextBox, UserName);
            SendTxt(PasswordTextField, Password);
        }

        public void UserLogIn()
        {
            ClickBtn(LoginBtn);
        }

        public bool DoesTheLoginErrorMessageDisplayed()
        {
            try
            {
                return ErrorMsg.Displayed;

            }

            catch (NoSuchElementException)
            {
                return false;
            }

        }

    }
}
