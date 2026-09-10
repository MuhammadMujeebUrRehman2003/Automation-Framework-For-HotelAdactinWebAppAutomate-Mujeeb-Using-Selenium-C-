using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.BookingConfirmationPage
{
    public class BookingConfirmationPage : BasePage
    {
        public static By clickonsearchhotelbutton_ = By.CssSelector("#search_hotel");
        public static By setupguidepdf_ = By.CssSelector("a[href*='SetupGuide.pdf']");
        public static By hoteladactinwebservice_ = By.CssSelector("a[href*='HotelAdactinWebServices']");
        public static By sampletestcaseshotelapppdf_ = By.CssSelector("a[href*='Sample-TestCases_HotelApplication.pdf']");
        public static By knowndefectshotelapppdf_ = By.CssSelector("a[href*='KnownDefects_HotelApp.pdf']");
        public static By adactinCoLink_ = By.LinkText("www.adactin.com");
        public static By adactinweblink_ = By.CssSelector("a[href='http://www.adactin.com']");

        public void ClickOnAdactinCoLinkOfBookingConfirmationPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinCoLink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Co Link");
        }

        public void ClickOnSearchHotelButtonFromBookingConfirmationPage(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonsearchhotelbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Button");
            Assert.AreEqual(message5, "Search Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnOtherLinksOfBookingConfirmationPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(setupguidepdf_)).Click();
            TakeScreenShot(Status.Pass, "Click On SetUp Guide PDF Link");
            wait.Until(d => d.FindElement(hoteladactinwebservice_)).Click();
            TakeScreenShot(Status.Pass, "Click On Hotel Adactin WebService Link");
            wait.Until(d => d.FindElement(sampletestcaseshotelapppdf_)).Click();
            TakeScreenShot(Status.Pass, "Click On Sample TestCases Hotel App PDF Link");
            wait.Until(d => d.FindElement(knowndefectshotelapppdf_)).Click();
            TakeScreenShot(Status.Pass, "Click On Known Defects Hotel App PDF Link");
        }

        public void ClickOnAdactinWebLinkOfBookingConfirmationPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinweblink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Web Link");
        }
    }
}