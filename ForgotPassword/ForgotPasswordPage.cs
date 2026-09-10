using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.ForgotPassword
{
    public class ForgotPasswordPage : BasePage
    {
        public static By gobacktologinpagebutton = By.LinkText("Go back to Login page");
        public static By setupguidepdf = By.CssSelector("a[href*='SetupGuide.pdf']");
        public static By hoteladactinwebservice = By.CssSelector("a[href*='HotelAdactinWebServices']");
        public static By sampletestcaseshotelapppdf = By.CssSelector("a[href*='Sample-TestCases_HotelApplication.pdf']");
        public static By knowndefectshotelapppdf = By.CssSelector("a[href*='KnownDefects_HotelApp.pdf']");
        public static By adactinweblink = By.CssSelector("a[href='http://www.adactin.com']");
        public static By adactinCoLink = By.LinkText("www.adactin.com");
        public static By email_ = By.Id("emailadd_recovery");
        public static By resetBTN = By.Id("Reset");
        public static By clickherelinkenteremail = By.Id("emailadd_recovery");
        public static By clickonemailpasswordsubmitbutton = By.Id("Submit");

        public void EnterEmailAndSubmitInForgotPassword(string email, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickherelinkenteremail)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter the Email");
            wait.Until(d => d.FindElement(clickonemailpasswordsubmitbutton)).Click();
            TakeScreenShot(Status.Pass, "Click on Email Password Button in Forgot Password");
            Assert.AreEqual(message2, "An email has been sent to your email address containing Username and Password. Please check your email.");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ForgotPasswordAndReset(string email)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(email_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter Email");
            wait.Until(d => d.FindElement(resetBTN)).Click();
            TakeScreenShot(Status.Pass, "Click on Reset Button");
        }

        public void ClickOnGoBackToLoginLinkInForgotPassword(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(gobacktologinpagebutton)).Click();
            TakeScreenShot(Status.Pass, "Click On Go back to Login page");
            Assert.AreEqual(message2, "Existing User Login - Build 1");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnOtherLinksOfForgotPasswordPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(setupguidepdf)).Click();
            TakeScreenShot(Status.Pass, "Click On Download to download the Adactin Hotel Mobile App Link");
            wait.Until(d => d.FindElement(hoteladactinwebservice)).Click();
            TakeScreenShot(Status.Pass, "Click On Click to visit the HotelApp Web Services Link");
            wait.Until(d => d.FindElement(sampletestcaseshotelapppdf)).Click();
            TakeScreenShot(Status.Pass, "Click On Download to downlaod the Sample TestCases Link");
            wait.Until(d => d.FindElement(knowndefectshotelapppdf)).Click();
            TakeScreenShot(Status.Pass, "Click On Download to downlaod the Known Defects Link");
        }

        public void ClickOnAdactinWebLinkOfForgotPasswordPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinweblink)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Web Link Of Forgot Password");
        }

        public void ClickOnAdactinCoLinkOfForgotPasswordPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinweblink)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin CO Link Of Forgot Password");
        }
    }
}