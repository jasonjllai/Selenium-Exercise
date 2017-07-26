using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;

namespace PageObjectDemo
{
    public class CarPage
    {
        //LinkText, Using = "BMW"
        [FindsBy(How = How.LinkText, Using = "BMW")]
        private IWebElement carLink;
        //clicklink
        public void ClickCar()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("BMW")));
            carLink.Click();

        }

        [FindsBy(How = How.Id, Using = "15")]
        private IWebElement model;

        [FindsBy(How = How.Id, Using = "min-18")]
        private IWebElement minPrice;

        [FindsBy(How = How.Id, Using = "max-18")]
        private IWebElement maxPrice;

        [FindsBy(How = How.Id, Using = "sidebar-54")]
        private IWebElement keyword;

        [FindsBy(How = How.CssSelector, Using = "input[value='2']")]
        private IWebElement rBtnAuckland;

        [FindsBy(How = How.CssSelector, Using = "button[class='button27 spriteButton search-button motorsSearchButton']")]
        private IWebElement searchBtn;

        public void Search(int seqModel, int seqMinPrice, int seqMaxPrice)
        {
            WebDriverWait wait1 = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 15));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.Id("15")));

            Actions action = new Actions(Browser.Driver);
            action.MoveToElement(keyword);

            SelectElement modelSelection = new SelectElement(Browser.Driver.FindElement(By.Id("15")));
            modelSelection.SelectByIndex(seqModel);

            SelectElement minPriceSelection = new SelectElement(Browser.Driver.FindElement(By.Id("min-18")));
            minPriceSelection.SelectByIndex(seqMinPrice);

            SelectElement maxPriceSelection = new SelectElement(Browser.Driver.FindElement(By.Id("max-18")));
            maxPriceSelection.SelectByIndex(seqMaxPrice);

            //keyword.SendKeys("abc");
            rBtnAuckland.Click();
            searchBtn.Click();

        }


    }
}
