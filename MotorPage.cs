using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;

namespace PageObjectDemo
{
    public class MotorPage
    {
        //link LinkText, Using = "Cars for sale"
        [FindsBy(How = How.LinkText, Using = "Cars for sale")]
        private IWebElement salesLink;
        //Click link
        public void ClickSale()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Cars for sale")));
            salesLink.Click();
        }

    }
}
