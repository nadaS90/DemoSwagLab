using AngleSharp.Dom;
using DemoSwagLab.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwagLab.Pages
{
    public class CartPage : PageBase
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        #region MyRegion
        //Locators :
        public const String CartLabelID = "//span[@class='shopping_cart_badge']";
        public const String CartItemsListID = "//div[@class='cart_list']";
        public const String OrderItemsDropDownID = "product_sort_container";
        public const String ActiveOrderOptionID = "active_option";
        public const String ItemBackPackID = "item_4_title_link";
        public const String ItembikeLightID = "add-to-cart-sauce-labs-bike-light";
        public const String RemoveBtnID = "remove-sauce-labs-backpack";
        public const String CheckOutBtnID = "checkout";
        #endregion
        public IWebElement CartLabel => driver.FindElement(By.XPath(CartLabelID));
        public IWebElement CartItemsList => driver.FindElement(By.XPath(CartItemsListID));
        public IWebElement CheckOutBtn => driver.FindElement(By.Id(CheckOutBtnID));
        public IWebElement RemoveBtn => driver.FindElement(By.Id(RemoveBtnID));
        public IWebElement ItemBackPack => driver.FindElement(By.Id(ItemBackPackID));




        public void CheckThatCartIsNotEmptyAfterAddingItems()
        {
            Assert.NotNull(CartItemsList);
        }

        public void ClickOnCheckOutBtn()
        {
            ClickBtn(CheckOutBtn);
        }

        public void ClickOnRemoveBtn()
        {
            ClickBtn(RemoveBtn);
        }

        public bool CheckItemIsNotDisplayed()
        {
            ImplicitWait();

            try
            {
                Assert.IsFalse(ItemBackPack.Displayed, "Element is displayed");
                return false;
            }
            catch (NoSuchElementException)
            {
                return true;
            }


        }
    




    }
}
