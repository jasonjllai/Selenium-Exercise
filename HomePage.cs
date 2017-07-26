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
    public class HomePage
    {
        //path of HomePage
        static string Url = "http://www.trademe.co.nz";
        //GoTo HomePage
        public void Goto()
        {
            Browser.GoTo(Url);
        }
        //link the LinkText"Motor"
        [FindsBy(How = How.LinkText, Using = "Motors")]
        private IWebElement motorLink;
        //click the link until it is visible
        public void ClickMotor()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Motors")));
            motorLink.Click();
        }

        [FindsBy(How = How.Id, Using = "LoginLink")]
        private IWebElement loginLink;

        public void ClickLogin()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("LoginLink")));
            loginLink.Click();
        }

    }
}
