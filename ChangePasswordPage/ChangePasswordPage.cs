using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.ChangePasswordPage
{
    public class ChangePasswordPage : BasePage
    {
        public static By clickonsearchhotellink_ = By.LinkText("Search Hotel");
        public static By clickonchangepasswordlink_ = By.LinkText("Change Password");
        public static By setupguidepdf_ = By.CssSelector("a[href*='SetupGuide.pdf']");
        public static By hoteladactinwebservice_ = By.CssSelector("a[href*='HotelAdactinWebServices']");
        public static By sampletestcaseshotelapppdf_ = By.CssSelector("a[href*='Sample-TestCases_HotelApplication.pdf']");
        public static By knowndefectshotelapppdf_ = By.CssSelector("a[href*='KnownDefects_HotelApp.pdf']");
        public static By clickonsubmitbutton_ = By.Id("Submit");
        public static By currentpasswordTXT_ = By.Id("current_pass");
        public static By newpasswordTXT_ = By.Id("new_password");
        public static By confirmpasswordTXT_ = By.Id("re_password");
        public static By adactinweblink_ = By.CssSelector("a[href='http://www.adactin.com']");
        public static By adactinCoLink_ = By.LinkText("www.adactin.com");

        public void ClickOnChangePasswordLinkFromSearchHotelPage(string message2, string currentpassword, string newpassword, string confirmpassword)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message2, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(currentpasswordTXT_)).SendKeys(currentpassword);
            TakeScreenShot(Status.Pass, "Enter Current Password");
            wait.Until(d => d.FindElement(newpasswordTXT_)).SendKeys(newpassword);
            TakeScreenShot(Status.Pass, "Enter New Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter Confirm Password");
            wait.Until(d => d.FindElement(clickonsubmitbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Submit Button");
        }

        public void ClickOnChangePasswordLinkFromSelectHotelPage(string message3, string currentpassword, string newpassword, string confirmpassword)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message3, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(currentpasswordTXT_)).SendKeys(currentpassword);
            TakeScreenShot(Status.Pass, "Enter Current Password");
            wait.Until(d => d.FindElement(newpasswordTXT_)).SendKeys(newpassword);
            TakeScreenShot(Status.Pass, "Enter New Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter Confirm Password");
            wait.Until(d => d.FindElement(clickonsubmitbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Submit Button");
        }

        public void ClickOnChangePasswordLinkFromBookHotelPage(string message4, string currentpassword, string newpassword, string confirmpassword)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message4, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(currentpasswordTXT_)).SendKeys(currentpassword);
            TakeScreenShot(Status.Pass, "Enter Current Password");
            wait.Until(d => d.FindElement(newpasswordTXT_)).SendKeys(newpassword);
            TakeScreenShot(Status.Pass, "Enter New Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter Confirm Password");
            wait.Until(d => d.FindElement(clickonsubmitbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Submit Button");
        }

        public void ClickOnChangePasswordLinkFromBookingConfirmationPage(string message5, string currentpassword, string newpassword, string confirmpassword)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message5, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(currentpasswordTXT_)).SendKeys(currentpassword);
            TakeScreenShot(Status.Pass, "Enter Current Password");
            wait.Until(d => d.FindElement(newpasswordTXT_)).SendKeys(newpassword);
            TakeScreenShot(Status.Pass, "Enter New Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter Confirm Password");
            wait.Until(d => d.FindElement(clickonsubmitbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Submit Button");
        }

        public void ClickOnChangePasswordLinkFromBookedItineraryPage(string message3, string currentpassword, string newpassword, string confirmpassword)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message3, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(currentpasswordTXT_)).SendKeys(currentpassword);
            TakeScreenShot(Status.Pass, "Enter Current Password");
            wait.Until(d => d.FindElement(newpasswordTXT_)).SendKeys(newpassword);
            TakeScreenShot(Status.Pass, "Enter New Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter Confirm Password");
            wait.Until(d => d.FindElement(clickonsubmitbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Submit Button");
        }

        public void ClickOnChangePasswordAndSearchHotelLink(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message2, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(clickonsearchhotellink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Link");
        }

        public void ClickOnChangePasswordAndOtherLinks(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message2, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(setupguidepdf_)).Click();
            TakeScreenShot(Status.Pass, "Click On SetUp Guide PDF Link");
            wait.Until(d => d.FindElement(hoteladactinwebservice_)).Click();
            TakeScreenShot(Status.Pass, "Click On Hotel Adactin WebService Link");
            wait.Until(d => d.FindElement(sampletestcaseshotelapppdf_)).Click();
            TakeScreenShot(Status.Pass, "Click On Sample TestCases Hotel App PDF Link");
            wait.Until(d => d.FindElement(knowndefectshotelapppdf_)).Click();
            TakeScreenShot(Status.Pass, "Click On Known Defects Hotel App PDF Link");
        }

        public void ChangePasswordFromChangePasswordPage(string message2, string currentpassword, string newpassword, string confirmpassword)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message2, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(currentpasswordTXT_)).SendKeys(currentpassword);
            TakeScreenShot(Status.Pass, "Enter Current Password");
            wait.Until(d => d.FindElement(newpasswordTXT_)).SendKeys(newpassword);
            TakeScreenShot(Status.Pass, "Enter New Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter Confirm Password");
            wait.Until(d => d.FindElement(clickonsubmitbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Submit Button");
        }

        public void ClickOnChangePasswordLink(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message2, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnAdactinWebLinkFromChangePasswordPage(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message2, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(adactinweblink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Web Link");
        }

        public void ClickOnAdactinCoLinkFromChangePasswordPage(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonchangepasswordlink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Change Password Link");
            Assert.AreEqual(message2, "Change Password");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(adactinCoLink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Co Link");
        }
    }
}