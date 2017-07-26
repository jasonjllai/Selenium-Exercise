using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectDemo
{
    public static class Browser
    {
        //create webDriver as Firebox
        static IWebDriver webDriver = new FirefoxDriver();

        //create driver for webDriver
        public static IWebDriver Driver
        {
            get
            {
                return webDriver;
            }
        }

        //create SDdriver for search
        public static ISearchContext SDriver
        {
            get
            {
                return webDriver;
            }
        }

        //create GoTo method
        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        //create Closw method
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
