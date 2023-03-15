using DemoSwagLab.Base;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;


namespace DemoSwagLab.Pages
{
    internal class HomePage : PageBase
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        #region MyRegion
        //Locators :
        public const String ItemNameID = "//div[@class='inventory_item_name']";
        public const String ItemPhotoID = "//img[@class='inventory_item_img']";
        public const String BurgerMenuID = "react -burger-menu-btn";
        public const String OrderItemsDropDownID = "product_sort_container";
        public const String CloseBurgerMenuID = "react-burger-cross-btn";
        public const String ActiveOrderOptionID = "active_option";
        public const String ItemBackPackID = "item_4_title_link";
        #endregion
        public IWebElement ItemName => driver.FindElement(By.XPath(ItemNameID));
        public IWebElement ItemPhoto => driver.FindElement(By.XPath(ItemPhotoID));
        public IWebElement BurgerMenu => driver.FindElement(By.Id(BurgerMenuID));
        public IWebElement ItemBackPack => driver.FindElement(By.Id(ItemBackPackID));
        public IWebElement CloseBurgerMenu => driver.FindElement(By.Id(CloseBurgerMenuID));
        public IWebElement OrderItemsDropDown => driver.FindElement(By.ClassName(OrderItemsDropDownID));
        public IWebElement ActiveOrderOption => driver.FindElement(By.ClassName(ActiveOrderOptionID));
        public string ItemPhotoDetails => ItemPhoto.Text;


        public bool DoesTheItemsPhotoDisplayed()
        {
            try
            {
                return ItemPhoto.Displayed;

            }

            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool DoesTheItemsNameDisplayed()
        {
            try
            {
                return ItemName.Displayed;

            }

            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public void SelectMenuOption(string option)
        {
            ClickBtn(BurgerMenu);
            // BurgerMenuOptions(option).Click();
        }

        public void SelectOrder(string option)
        {
            SelectElement orderOptionDropdown = new SelectElement(OrderItemsDropDown);
            if (!ActiveOrderOption.Text.Contains(option))
            {
                ImplicitWait();
                orderOptionDropdown.SelectByText(option);
            }
        }

        public void VerifyThatSortingByOrderAppliedCorrectly(string option)
        {
            ImplicitWait();
            string currentOrderOption = this.ActiveOrderOption.Text;
            Assert.AreEqual(option.ToLower(), currentOrderOption.ToLower(), "Order is not applied");
        }

       public void SelectAnItem()
        {
            ClickBtn(ItemBackPack);
        }

    }
}
