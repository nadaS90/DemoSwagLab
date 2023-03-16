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
        public const String BurgerMenuID = "react -burger-menu-btn";


        #endregion

        public IWebElement CloseBurgerMenu => driver.FindElement(By.Id(CloseBurgerMenuID));
        public IWebElement BurgerMenu => driver.FindElement(By.Id(BurgerMenuID));
        public IWebElement BurgerMenuOptions(string optionName) => driver.FindElement(By.XPath($"//nav[@class='bm-item-list']//a[text()='{optionName}']"));
        public IWebElement Cart => driver.FindElement(By.ClassName(CartID));





        public void SelectMenuOption(string burgerMenuOption)
        {
            ClickBtn(BurgerMenu);
            BurgerMenuOptions(burgerMenuOption).Click();
        }


        public void NavigatesToCart()
        {
            ClickBtn(Cart);
        }
    }
}
