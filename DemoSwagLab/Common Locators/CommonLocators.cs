using DemoSwagLab.Base;
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
        #endregion

        public IWebElement BurgerMenuOptions(string optionName) => driver.FindElement(By.XPath($"//nav[@class='bm-item-list']//a[text()='{optionName}']"));
        public IWebElement AddToCartButton(string productName) => driver.FindElement(By.XPath($"//div[@class='pricebar']/button[contains(@data-test, {productName})]"));
        public IWebElement Cart => driver.FindElement(By.ClassName(CartID));




        public void NavigateToYourCartPage()
        {
            ClickBtn(Cart);
        }

        public void AddProductToCart(string productName)
        {
            string parsedProductTitle = productName.ToLower().Replace(" ", "-");
            AddToCartButton(parsedProductTitle).Click();
        }

    }
}
