using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.LoginPage
{
    public class LoginPage : BasePage
    {
        public static By usernameTXT = By.Id("username");
        public static By passwordTXT = By.Id("password");
        public static By loginBTN = By.Id("login");
        public static By clickherelink = By.LinkText("Click here");
        public static By clicknewuserregistrationlink = By.LinkText("New User Register Here");
        public static By errorelementLocator = By.XPath("//b[contains(text(),'Invalid Login details')]");
        public static By clickongotobuild2 = By.LinkText("Go to Build 2");
        public static By infoofadactinweb = By.LinkText("info@adactin.com");
        public static By ioslink = By.CssSelector("a[href='https://testflight.apple.com/join/Ai3nVPMD']");
        public static By appstorelink = By.CssSelector("a[href='https://play.google.com/store/apps/details?id=com.adactin.education.hotelbooking']");
        public static By adactinCoLink = By.LinkText("Adactin.com");

        public void LoginWithValidCredentials(string url, string username, string password, string message)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(usernameTXT)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter Username");
            wait.Until(d => d.FindElement(passwordTXT)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter Password");
            wait.Until(d => d.FindElement(loginBTN)).Click();
            TakeScreenShot(Status.Pass, "Click on Login Button");
            Assert.AreEqual(message, "Welcome to Adactin Group of Hotels");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void LoginWithInvalidUsernameCredentials(string url, string username, string password, string UsernameErrorMessage)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(usernameTXT)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter Username");
            wait.Until(d => d.FindElement(passwordTXT)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter Password");
            wait.Until(d => d.FindElement(loginBTN)).Click();
            TakeScreenShot(Status.Pass, "Click on Login Button");
            Assert.AreEqual(UsernameErrorMessage, "Invalid Login details or Your Password might have expired. Click here to reset your password");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void LoginWithInvalidUsernameAndPasswordCredentials(string url, string username, string password, string expectedErrorMessage)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(usernameTXT)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter Username");
            wait.Until(d => d.FindElement(passwordTXT)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter Password");
            wait.Until(d => d.FindElement(loginBTN)).Click();
            TakeScreenShot(Status.Pass, "Click on Login Button");
            string actualErrorMessage = driver.FindElement(errorelementLocator).Text;
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage);
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void LoginWithInvalidPasswordCredentials(string url, string username, string password, string expectedErrorMessage)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(usernameTXT)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter Username");
            wait.Until(d => d.FindElement(passwordTXT)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter Password");
            wait.Until(d => d.FindElement(loginBTN)).Click();
            TakeScreenShot(Status.Pass, "Click on Login Button");
            Assert.AreEqual(expectedErrorMessage, "Enter Password");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void LoginWithClickHereLink(string url, string username, string password, string message, string expectedErrorMessage)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(usernameTXT)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter Username");
            wait.Until(d => d.FindElement(passwordTXT)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter Password");
            wait.Until(d => d.FindElement(loginBTN)).Click();
            TakeScreenShot(Status.Pass, "Click on Login Button");
            wait.Until(d => d.FindElement(clickherelink)).Click();
            TakeScreenShot(Status.Pass, "Click on Click here Link Of Login Page");
            Assert.AreEqual(message, "Forgot Password Form");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnNewUserRegisterHereLink(string url, string message)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(clicknewuserregistrationlink)).Click();
            TakeScreenShot(Status.Pass, "Click on Click here Link Of Login Page");
            Assert.AreEqual(message, "New User Registration Form");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void LoginWithEmptyCredentials(string url, string username, string password, string UsernameErrorMessage)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(usernameTXT)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter Username");
            wait.Until(d => d.FindElement(passwordTXT)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter Password");
            wait.Until(d => d.FindElement(loginBTN)).Click();
            TakeScreenShot(Status.Pass, "Click on Login Button");
            Assert.AreEqual(UsernameErrorMessage, "Enter Username");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void LoginPageGoToBuild2(string url, string username, string password, string message)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(usernameTXT)).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter Username");
            wait.Until(d => d.FindElement(passwordTXT)).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter Password");
            wait.Until(d => d.FindElement(clickongotobuild2)).Click();
            TakeScreenShot(Status.Pass, "Click on Go to Build 2 Link Of Login Page");
            Assert.AreEqual(message, "Welcome to Adactin Group of Hotels");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void LoginPageMailToAdactin(string url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(infoofadactinweb)).Click();
            TakeScreenShot(Status.Pass, "Click on Link info@adactin.com in Login Page");
        }

        public void LoginPageIosLink(string url, string message)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(ioslink)).Click();
            TakeScreenShot(Status.Pass, "Click on ios Image Link");
            Assert.AreEqual(message, "Testing Apps with TestFlight");
            TakeScreenShot(Status.Pass, "Click on ios Image Link in Login Page");
        }

        public void LoginPageAppStoreLink(string url, string message)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            wait.Until(d => d.FindElement(appstorelink)).Click();
            TakeScreenShot(Status.Pass, "Click on Google App Store Image Link");
            Assert.AreEqual(message, "We're sorry, the requested URL was not found on this server.");
            TakeScreenShot(Status.Pass, "Click on Google App Store Image Link in Login Page");
        }

        public void ClickOnLoginPageAdactinCoLink(string url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(url);
            TakeScreenShot(Status.Pass, "Enter URL");
            IWebElement link = wait.Until(d =>
            {
                var element = d.FindElement(adactinCoLink);
                return element.Displayed && element.Enabled ? element : null;
            });
            link.Click();
            TakeScreenShot(Status.Pass, "Click on Co Link Of Login Page");
        }
    }
}