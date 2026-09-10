using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.MyItineraryPage
{
    public class MyItineraryPage : BasePage
    {
        public static By clickonsearchhotellink_ = By.LinkText("Search Hotel");
        public static By clickonbookeditinerarylink_ = By.LinkText("Booked Itinerary");
        public static By clickonmyitinerary_ = By.CssSelector("#my_itinerary");
        public static By clickonlogout_ = By.LinkText("Logout");
        public static By firstnameTXT_ = By.Id("first_name");
        public static By lastnameTXT_ = By.Id("last_name");
        public static By billingaddressTXT_ = By.Id("address");
        public static By creditcardnoTXT_ = By.Id("cc_num");
        public static By selectcreditcardtype_ = By.Id("cc_type");
        public static By selectmonth_ = By.Id("cc_exp_month");
        public static By selectyear_ = By.Id("cc_exp_year");
        public static By cvvnumberTXT_ = By.Id("cc_cvv");
        public static By clickoncancel_ = By.Id("cancel");

        public void VisitMyItineraryPage(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message2, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnMyItineraryAndSearchThroughOrderId(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonmyitinerary_)).Click();
            TakeScreenShot(Status.Pass, "Click On My Itinerary Button");
            Assert.AreEqual(message5, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnMyItineraryAndSearchHotel(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message5, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(clickonsearchhotellink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Link");
        }

        public void ClickOnMyItineraryAndLogout(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonbookeditinerarylink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Booked Itinerary Link");
            Assert.AreEqual(message5, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Link");
        }

        public void ClickOnMyItineraryAndCancelSelection(string firstname, string lastname, string billingaddress, string creditcardno, string creditcardtype, string month, string year, string cvvnumber, string message4)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(firstnameTXT_)).SendKeys(firstname);
            TakeScreenShot(Status.Pass, "Enter The First Name");
            wait.Until(d => d.FindElement(lastnameTXT_)).SendKeys(lastname);
            TakeScreenShot(Status.Pass, "Enter The Last Name");
            wait.Until(d => d.FindElement(billingaddressTXT_)).SendKeys(billingaddress);
            TakeScreenShot(Status.Pass, "Enter The Billing Address");
            wait.Until(d => d.FindElement(creditcardnoTXT_)).SendKeys(creditcardno);
            TakeScreenShot(Status.Pass, "Enter The Credit Card Number");
            SelectElement selectcreditcardtype = new SelectElement(wait.Until(d => d.FindElement(selectcreditcardtype_)));
            selectcreditcardtype.SelectByText(creditcardtype);
            TakeScreenShot(Status.Pass, "Credit Card Type Selected");
            SelectElement selectmonth = new SelectElement(wait.Until(d => d.FindElement(selectmonth_)));
            selectmonth.SelectByText(month);
            TakeScreenShot(Status.Pass, "Month Selected");
            SelectElement selectyear = new SelectElement(wait.Until(d => d.FindElement(selectyear_)));
            selectyear.SelectByText(year);
            TakeScreenShot(Status.Pass, "Year Selected");
            wait.Until(d => d.FindElement(cvvnumberTXT_)).SendKeys(cvvnumber);
            TakeScreenShot(Status.Pass, "Enter The CVV Number");
            wait.Until(d => d.FindElement(clickoncancel_)).Click();
            TakeScreenShot(Status.Pass, "Click On Cancel Button");
            Assert.AreEqual(message4, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnMyItineraryButton(string message5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonmyitinerary_)).Click();
            TakeScreenShot(Status.Pass, "Click On My Itinerary Button");
            Assert.AreEqual(message5, "Booked Itinerary");
            TakeScreenShot(Status.Pass, "Verify Message");
        }
    }
}