using DemoSwagLab.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwagLab.Pages
{
    public class ItemDetailsPage : PageBase
    {
        public ItemDetailsPage(IWebDriver driver) : base(driver)
        {
        }

        #region MyRegion
        //Locators :
        public const String ItemNameID = "//div[@class='inventory_details_name large_size']";


        #endregion
        public IWebElement ItemName => driver.FindElement(By.XPath(ItemNameID));
        public string CorrectItemName => ItemName.Text;


        // public string ItemPhotoDetails => ItemPhoto.Text;


        public bool DoesTheItemNameDisplayed()
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

    }
}
