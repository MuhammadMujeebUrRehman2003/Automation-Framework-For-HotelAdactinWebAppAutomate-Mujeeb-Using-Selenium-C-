using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.SelectHotelPage
{
    public class SelectHotelPage : BasePage
    {
        public static By radiobutton_ = By.Id("radiobutton_0");
        public static By clickoncontinue_ = By.Id("continue");
        public static By clickoncancel_ = By.Id("cancel");
        public static By clickonsearchhotelbutton_ = By.CssSelector("#search_hotel");
        public static By clickonsearchhotellink_ = By.LinkText("Search Hotel");
        public static By setupguidepdf_ = By.CssSelector("a[href*='SetupGuide.pdf']");
        public static By hoteladactinwebservice_ = By.CssSelector("a[href*='HotelAdactinWebServices']");
        public static By sampletestcaseshotelapppdf_ = By.CssSelector("a[href*='Sample-TestCases_HotelApplication.pdf']");
        public static By knowndefectshotelapppdf_ = By.CssSelector("a[href*='KnownDefects_HotelApp.pdf']");
        public static By adactinweblink_ = By.CssSelector("a[href='http://www.adactin.com']");
        public static By adactinCoLink_ = By.LinkText("www.adactin.com");

        public void SelectHotelAndClickRadioButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(radiobutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Radio Button");
        }

        public void SelectHotelAndContinue(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(radiobutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Radio Button");
            wait.Until(d => d.FindElement(clickoncontinue_)).Click();
            TakeScreenShot(Status.Pass, "Click On Continue Button");
            Assert.AreEqual(message3, "Book A Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void SelectHotelAndCancel(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(radiobutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Radio Button");
            wait.Until(d => d.FindElement(clickoncancel_)).Click();
            TakeScreenShot(Status.Pass, "Click On Cancel Button");
            Assert.AreEqual(message3, "Book A Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void SelectHotelAndCancelBooking(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(radiobutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Radio Button");
            wait.Until(d => d.FindElement(clickoncontinue_)).Click();
            TakeScreenShot(Status.Pass, "Click On Continue Button");
            Assert.AreEqual(message3, "Book A Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnSearchHotelButton(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonsearchhotelbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Button");
            Assert.AreEqual(message5, "Search Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnSearchHotelLink(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonsearchhotellink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Link");
            Assert.AreEqual(message3, "Search Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnOtherLinksOfSelectHotelPage()
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

        public void ClickOnAdactinWebLinkOfSelectHotelPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinweblink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Web Link");
        }

        public void ClickOnAdactinCoLinkOfSelectHotelPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinCoLink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Co Link");
        }
    }
}