using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;

namespace PageObjectDemo
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "page_email")]
        private IWebElement emailInput;

        [FindsBy(How = How.Id, Using = "page_password")]
        private IWebElement passwordInput;

        [FindsBy(How = How.Id, Using = "LoginPageButton")]
        private IWebElement loginButton;

        public void Login(string email, string password)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("page_email")));
            emailInput.SendKeys(email);

            WebDriverWait wait1 = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.Id("page_password")));
            passwordInput.SendKeys(password);

            WebDriverWait wait2 = new WebDriverWait(Browser.Driver, new TimeSpan(0, 0, 30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.Id("LoginPageButton")));
            loginButton.Click();
        }

    }
}
