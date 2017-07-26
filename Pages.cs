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
    public static class Pages
    {
        //initialise HomePage
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.SDriver, homePage);
                return homePage;
            }
        }
        //initialise MotorPage
        public static MotorPage MotorPage
        {
            get
            {
                var motorPage = new MotorPage();
                PageFactory.InitElements(Browser.SDriver, motorPage);
                return motorPage;
            }
        }
        //initialise CarPage
        public static CarPage CarPage
        {
            get
            {
                var carPage = new CarPage();
                PageFactory.InitElements(Browser.SDriver, carPage);
                return carPage;
            }
        }

        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Browser.SDriver, loginPage);
                return loginPage;
            }
        }

    }
}
