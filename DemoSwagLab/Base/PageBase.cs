using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwagLab.Base
{
    public class PageBase
    {
        public IWebDriver driver;

        public SelectElement Select;

        public PageBase(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }
        public string GetCurrentUrl()
        {
            return driver.Url;
        }

        public static void ClickBtn(IWebElement button)
        {
            button.Click();
        }

        public static void SendTxt(IWebElement textElm, string value)
        {
            textElm.SendKeys(value);
        }

        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


    }
}
