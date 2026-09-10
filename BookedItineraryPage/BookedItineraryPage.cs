using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.BookedItineraryPage
{
    public class BookedItineraryPage : BasePage
    {
        public static By clickonsearchhotellink_ = By.LinkText("Search Hotel");
        public static By clickonbookeditinerarylink_ = By.LinkText("Booked Itinerary");
        public static By adactinweblink_ = By.CssSelector("a[href='http://www.adactin.com']");

        public void ClickOnBookedItineraryLinkFromSearchHotelPage(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message2, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnBookedItineraryLinkFromSelectHotelPage(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message3, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnBookedItineraryLinkFromBookHotelPage(string message4)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message4, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnBookedItineraryLinkFromBookingConfirmationPage(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message5, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnSearchHotelLinkFromBookedItineraryPage(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonsearchhotellink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Link");
            Assert.AreEqual(message3, "Search Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnBookedItineraryLinkFromBookedItineraryPage(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message2, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link Again");
        }

        public void ClickOnAdactinWebLinkFromBookedItineraryPage(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message2, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(adactinweblink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Web Link");
        }
    }
}