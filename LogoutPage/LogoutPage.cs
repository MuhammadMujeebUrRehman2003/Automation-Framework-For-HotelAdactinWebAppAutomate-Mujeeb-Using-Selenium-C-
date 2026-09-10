using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.LogoutPage
{
    public class LogoutPage : BasePage
    {
        public static By clickonlogout_ = By.LinkText("Logout");

        public void ClickOnLogoutLinkFromSearchHotelPage(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Link");
            Assert.AreEqual(message2, "You have successfully logged out.");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnLogoutLinkFromSelectHotelPage(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Link");
            Assert.AreEqual(message3, "You have successfully logged out.");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnLogoutLinkFromBookHotelPage(string message4)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Link");
            Assert.AreEqual(message4, "You have successfully logged out.");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnLogoutLinkFromBookingConfirmationPage(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Link");
            Assert.AreEqual(message5, "You have successfully logged out.");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnLogoutLinkFromBookedItineraryPage(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Link");
            Assert.AreEqual(message3, "You have successfully logged out.");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnLogoutLinkFromChangePasswordPage(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Link");
            Assert.AreEqual(message3, "You have successfully logged out.");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnLogoutButtonAfterBooking(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Button");
            Assert.AreEqual(message5, "You have successfully logged out.");
            TakeScreenShot(Status.Pass, "Verify Message");
        }
    }
}