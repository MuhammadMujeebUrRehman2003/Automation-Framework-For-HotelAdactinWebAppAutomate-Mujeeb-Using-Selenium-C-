using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.RegistrationPage
{
    public class RegistrationPage : BasePage
    {
        public static By usernameTXT_ = By.Id("username");
        public static By passwordTXT_ = By.Id("password");
        public static By confirmpasswordTXT_ = By.Id("re_password");
        public static By fullname_ = By.Id("full_name");
        public static By emailaddress_ = By.Id("email_add");
        public static By captchatext_ = By.XPath("//td[contains(text(),'Captcha Text')]/following::input[1]");
        public static By check_ = By.Id("tnc_box");
        public static By registerBTN_ = By.Id("Submit");
        public static By resetBTN_ = By.Id("Reset");
        public static By relogin_ = By.LinkText("Go back to Login page");
        public static By setupguidepdf_ = By.CssSelector("a[href*='SetupGuide.pdf']");
        public static By hoteladactinwebservice_ = By.CssSelector("a[href*='HotelAdactinWebServices']");
        public static By sampletestcaseshotelapppdf_ = By.CssSelector("a[href*='Sample-TestCases_HotelApplication.pdf']");
        public static By knowndefectshotelapppdf_ = By.CssSelector("a[href*='KnownDefects_HotelApp.pdf']");
        public static By adactinweblink_ = By.CssSelector("a[href='http://www.adactin.com']");
        public static By adactinCoLink_ = By.LinkText("Adactin.com");

        public void ResetRegistrationWithValidCredentials(string username, string password, string confirmpassword, string fullname, string email)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            wait.Until(d => d.FindElement(check_)).Click();
            TakeScreenShot(Status.Pass, "Click On Checkbox");
            wait.Until(d => d.FindElement(resetBTN_)).Click();
            TakeScreenShot(Status.Pass, "Click On Reset Button");
            Assert.IsTrue(driver.PageSource.ToLower().Contains("captcha"), "Captcha validation message not displayed");
            TakeScreenShot(Status.Pass, "Captcha Validation Verified");
        }

        public void RegisterWithoutCaptcha(string username, string password, string confirmpassword, string fullname, string email)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            wait.Until(d => d.FindElement(check_)).Click();
            TakeScreenShot(Status.Pass, "Click On Checkbox");
            wait.Until(d => d.FindElement(registerBTN_)).Click();
            TakeScreenShot(Status.Pass, "Click On Register Button");
            Assert.IsTrue(driver.PageSource.ToLower().Contains("captcha"), "Captcha validation message not displayed");
            TakeScreenShot(Status.Pass, "Captcha Validation Verified");
        }

        public void RegisterWithoutUsername(string username, string password, string confirmpassword, string fullname, string email, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            Assert.AreEqual(message2, "Username is Empty");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            wait.Until(d => d.FindElement(check_)).Click();
            TakeScreenShot(Status.Pass, "Click On Checkbox");
            wait.Until(d => d.FindElement(registerBTN_)).Click();
            TakeScreenShot(Status.Pass, "Click On Register Button");
            Assert.IsTrue(driver.PageSource.ToLower().Contains("captcha"), "Captcha validation message not displayed");
            TakeScreenShot(Status.Pass, "Captcha Validation Verified");
        }

        public void RegisterWithoutPassword(string username, string password, string confirmpassword, string fullname, string email, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            Assert.AreEqual(message2, "Password is Empty");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            wait.Until(d => d.FindElement(check_)).Click();
            TakeScreenShot(Status.Pass, "Click On Checkbox");
            wait.Until(d => d.FindElement(registerBTN_)).Click();
            TakeScreenShot(Status.Pass, "Click On Register Button");
            Assert.IsTrue(driver.PageSource.ToLower().Contains("captcha"), "Captcha validation message not displayed");
            TakeScreenShot(Status.Pass, "Captcha Validation Verified");
        }

        public void RegisterWithoutConfirmPassword(string username, string password, string confirmpassword, string fullname, string email, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            Assert.AreEqual(message2, "Confirm Password is Empty");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            wait.Until(d => d.FindElement(check_)).Click();
            TakeScreenShot(Status.Pass, "Click On Checkbox");
            wait.Until(d => d.FindElement(registerBTN_)).Click();
            TakeScreenShot(Status.Pass, "Click On Register Button");
            Assert.IsTrue(driver.PageSource.ToLower().Contains("captcha"), "Captcha validation message not displayed");
            TakeScreenShot(Status.Pass, "Captcha Validation Verified");
        }

        public void RegisterWithoutFullName(string username, string password, string confirmpassword, string fullname, string email, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            Assert.AreEqual(message2, "Full Name is Empty");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            wait.Until(d => d.FindElement(check_)).Click();
            TakeScreenShot(Status.Pass, "Click On Checkbox");
            wait.Until(d => d.FindElement(registerBTN_)).Click();
            TakeScreenShot(Status.Pass, "Click On Register Button");
            Assert.IsTrue(driver.PageSource.ToLower().Contains("captcha"), "Captcha validation message not displayed");
            TakeScreenShot(Status.Pass, "Captcha Validation Verified");
        }

        public void RegisterWithoutEmailAddress(string username, string password, string confirmpassword, string fullname, string email, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            Assert.AreEqual(message2, "Email Address is Empty");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(check_)).Click();
            TakeScreenShot(Status.Pass, "Click On Checkbox");
            wait.Until(d => d.FindElement(registerBTN_)).Click();
            TakeScreenShot(Status.Pass, "Click On Register Button");
            Assert.IsTrue(driver.PageSource.ToLower().Contains("captcha"), "Captcha validation message not displayed");
            TakeScreenShot(Status.Pass, "Captcha Validation Verified");
        }

        public void RegisterWithoutTermsAndConditionsCheck(string username, string password, string confirmpassword, string fullname, string email, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            Assert.AreEqual(message2, "You must agree to Terms and Conditions");
            TakeScreenShot(Status.Pass, "Verify Message");
            wait.Until(d => d.FindElement(registerBTN_)).Click();
            TakeScreenShot(Status.Pass, "Click On Register Button");
            Assert.IsTrue(driver.PageSource.ToLower().Contains("captcha"), "Captcha validation message not displayed");
            TakeScreenShot(Status.Pass, "Captcha Validation Verified");
        }

        public void RegisterWithEmptyCredentials(string username, string password, string confirmpassword, string fullname, string email, string message2, string message3, string message4, string message5, string message6, string message7)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(usernameTXT_)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter The Username");
            wait.Until(d => d.FindElement(passwordTXT_)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter The Password");
            wait.Until(d => d.FindElement(confirmpasswordTXT_)).SendKeys(confirmpassword);
            TakeScreenShot(Status.Pass, "Enter The Confirm Password");
            wait.Until(d => d.FindElement(fullname_)).SendKeys(fullname);
            TakeScreenShot(Status.Pass, "Enter The Full Name");
            wait.Until(d => d.FindElement(emailaddress_)).SendKeys(email);
            TakeScreenShot(Status.Pass, "Enter The Email Address");
            wait.Until(d => d.FindElement(captchatext_)).SendKeys("");
            TakeScreenShot(Status.Pass, "Keep the Captcha Text Empty");
            wait.Until(d => d.FindElement(registerBTN_)).Click();
            TakeScreenShot(Status.Pass, "Clicked Register button");
            try
            {
                IWebElement errorMsg = wait.Until(d => d.FindElement(By.XPath("//span[@class='reg_error'] | //div[@class='error']")));
                string fullErrorText = errorMsg.Text;
                TakeScreenShot(Status.Pass, $"Full error text: {fullErrorText}");
                Assert.IsTrue(driver.PageSource.Contains(message2), $"Expected '{message2}' not found.");
                TakeScreenShot(Status.Pass, "Username is Empty");
                Assert.IsTrue(driver.PageSource.Contains(message3), $"Expected '{message3}' not found.");
                TakeScreenShot(Status.Pass, "Password is Empty");
                Assert.IsTrue(driver.PageSource.Contains(message4), $"Expected '{message4}' not found.");
                TakeScreenShot(Status.Pass, "Confirm Password is Empty");
                Assert.IsTrue(driver.PageSource.Contains(message5), $"Expected '{message5}' not found.");
                TakeScreenShot(Status.Pass, "Full Name is Empty");
                Assert.IsTrue(driver.PageSource.Contains(message6), $"Expected '{message6}' not found.");
                TakeScreenShot(Status.Pass, "Email Address is Empty");
                Assert.IsTrue(driver.PageSource.Contains(message7), $"Expected '{message7}' not found.");
                TakeScreenShot(Status.Pass, "You must agree to Terms and Conditions");
                TakeScreenShot(Status.Pass, "All error messages verified");
            }
            catch (Exception ex)
            {
                TakeScreenShot(Status.Fail, $"Error during validation: {ex.Message}");
                throw;
            }
        }

        public void ClickOnGoBackToLoginLink(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(relogin_)).Click();
            TakeScreenShot(Status.Pass, "Click On Go back to Login page");
            Assert.AreEqual(message2, "Existing User Login - Build 1");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void VisitRegistrationPageAndClickOnOtherLinks()
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

        public void ClickOnAdactinWebLinkOfRegistrationPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinweblink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Web Link Of Registrartion");
        }

        public void ClickOnAdactinCoLinkOfRegistrationPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinCoLink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Co Link Of Registrartion");
        }
    }
}