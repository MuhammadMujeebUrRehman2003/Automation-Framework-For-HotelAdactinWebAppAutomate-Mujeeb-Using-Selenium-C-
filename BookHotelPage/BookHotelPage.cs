using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.BookHotelPage
{
    public class BookHotelPage : BasePage
    {
        public static By clickonsearchhotellink_ = By.LinkText("Search Hotel");
        public static By setupguidepdf_ = By.CssSelector("a[href*='SetupGuide.pdf']");
        public static By hoteladactinwebservice_ = By.CssSelector("a[href*='HotelAdactinWebServices']");
        public static By sampletestcaseshotelapppdf_ = By.CssSelector("a[href*='Sample-TestCases_HotelApplication.pdf']");
        public static By knowndefectshotelapppdf_ = By.CssSelector("a[href*='KnownDefects_HotelApp.pdf']");
        public static By adactinCoLink_ = By.LinkText("www.adactin.com");
        public static By adactinweblink_ = By.CssSelector("a[href='http://www.adactin.com']");
        public static By cvvnumberTXT_ = By.Id("cc_cvv");
        public static By clickonbooknow_ = By.Id("book_now");
        public static By firstnameTXT_ = By.Id("first_name");
        public static By lastnameTXT_ = By.Id("last_name");
        public static By billingaddressTXT_ = By.Id("address");
        public static By creditcardnoTXT_ = By.Id("cc_num");
        public static By selectcreditcardtype_ = By.Id("cc_type");
        public static By selectmonth_ = By.Id("cc_exp_month");
        public static By selectyear_ = By.Id("cc_exp_year");

        public void BookHotel(string firstname, string lastname, string billingaddress, string creditcardno, string creditcardtype, string month, string year, string cvvnumber, string message4)
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
            TakeScreenShot(Status.Pass, "Selecting The Credit Card Number");
            SelectElement selectcreditcardtype = new SelectElement(wait.Until(d => d.FindElement(selectcreditcardtype_)));
            selectcreditcardtype.SelectByText(creditcardtype);
            TakeScreenShot(Status.Pass, "Credit Card Number Selected");
            TakeScreenShot(Status.Pass, "Selecting The Month");
            SelectElement selectmonth = new SelectElement(wait.Until(d => d.FindElement(selectmonth_)));
            selectmonth.SelectByText(month);
            TakeScreenShot(Status.Pass, "Month Selected");
            TakeScreenShot(Status.Pass, "Selecting The Year");
            SelectElement selectyear = new SelectElement(wait.Until(d => d.FindElement(selectyear_)));
            selectyear.SelectByText(year);
            TakeScreenShot(Status.Pass, "Year Selected");
            wait.Until(d => d.FindElement(cvvnumberTXT_)).SendKeys(cvvnumber);
            TakeScreenShot(Status.Pass, "Enter The CVV Number");
            wait.Until(d => d.FindElement(clickonbooknow_)).Click();
            TakeScreenShot(Status.Pass, "Click On Book Now Button");
            Assert.AreEqual(message4, "Booking Confirmation");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnSearchHotelLinkFromBookHotelPage(string message4)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonsearchhotellink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Link");
            Assert.AreEqual(message4, "Search Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnOtherLinksOfBookHotelPage()
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

        public void ClickOnAdactinWebLinkOfBookHotelPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinweblink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Web Link");
        }

        public void ClickOnAdactinCoLinkOfBookHotelPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinCoLink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Co Link");
        }
    }
}