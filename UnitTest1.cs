using System;
using PageObjectDemo;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPageObjectDemo
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test1()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.ClickMotor();
            Pages.MotorPage.ClickSale();
            Pages.CarPage.ClickCar();
            Pages.CarPage.Search(3, 5, 7);
            Browser.Close();


        }
    }
}
