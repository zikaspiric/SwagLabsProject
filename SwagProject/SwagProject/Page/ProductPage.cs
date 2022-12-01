﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwagProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagProject.Page
{
    public class ProductPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement AddBackPack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement AddT_Short => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Cart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));
        public IWebElement SortByHighPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement MenuClick => driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement AboutClick => driver.FindElement(By.Id("about_sidebar_link"));

        public IWebElement ShopCartClick => driver.FindElement(By.Id("shopping_cart_container"));
        

        public void SelectOption(string text)

        {
            SelectElement element = new SelectElement(SortByHighPrice);
            element.SelectByText(text);
        }

    }
    
    
}
