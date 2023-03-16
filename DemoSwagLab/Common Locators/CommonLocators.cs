using DemoSwagLab.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwagLab.Common_Locators
{
    internal class CommonLocators : PageBase
    {
        public CommonLocators(IWebDriver driver) : base(driver)
        {
        }

        #region MyRegion
        //Locators :
        public const String CartID = "shopping_cart_link";
        public const String CloseBurgerMenuID = "react-burger-cross-btn";
        public const String BurgerMenuID = "react-burger-menu-btn";
        public const String AboutLinkID = "about_sidebar_link";



        #endregion

        public IWebElement CloseBurgerMenu => driver.FindElement(By.Id(CloseBurgerMenuID));
        public IWebElement BurgerMenu => driver.FindElement(By.Id(BurgerMenuID));
        public IWebElement AboutLink => driver.FindElement(By.Id(AboutLinkID));
        public IWebElement Cart => driver.FindElement(By.ClassName(CartID));





        public void SelectMenuOption()
        {
            ClickBtn(BurgerMenu);
        }

        public void ClickOnAboutLink()
        {
            ClickBtn(AboutLink);
           
        }
        public void GetNewTabDetails()
        {
            Console.WriteLine("Current window id: " + driver.CurrentWindowHandle);
            Console.WriteLine("Page title in second tab is: " + driver.Title);
        }
        public void NavigatesToCart()
        {
            ClickBtn(Cart);
        }
    }
}
