using AdactinWebAutomate.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinWebAutomate.RegistrationPage
{
    [TestClass]
    public class RegistrationPageTestCases : ExtentReport
    {
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        RegistrationPage registrationPage = new RegistrationPage();
        BasePage basePage = new BasePage();

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            basePage.SeleniumInit();
            exParentTest = extentReports.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void TearDown()
        {
            basePage.DriverClose();
            extentReports.Flush();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ResetRegister", DataAccessMethod.Sequential)]
        public void ResetRegister()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials and Click On Reset Button");
            registrationPage.ResetRegistrationWithValidCredentials(username, password, confirmpassword, fullname, email);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterWithoutCaptcha", DataAccessMethod.Sequential)]
        public void RegisterWithoutCaptcha()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials But Without Captcha");
            registrationPage.RegisterWithoutCaptcha(username, password, confirmpassword, fullname, email);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterWithoutUsername", DataAccessMethod.Sequential)]
        public void RegisterWithoutUsername()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials but Without Username");
            registrationPage.RegisterWithoutUsername(username, password, confirmpassword, fullname, email, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterWithoutPassword", DataAccessMethod.Sequential)]
        public void RegisterWithoutPassword()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials but Without Password");
            registrationPage.RegisterWithoutPassword(username, password, confirmpassword, fullname, email, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterWithoutConfirmPassword", DataAccessMethod.Sequential)]
        public void RegisterWithoutConfirmPassword()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials but Without Confirm Password");
            registrationPage.RegisterWithoutConfirmPassword(username, password, confirmpassword, fullname, email, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterWithoutFullName", DataAccessMethod.Sequential)]
        public void RegisterWithoutFullName()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials but Without Full Name");
            registrationPage.RegisterWithoutFullName(username, password, confirmpassword, fullname, email, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterWithoutEmailAddress", DataAccessMethod.Sequential)]
        public void RegisterWithoutEmailAddress()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials but Without Email Address");
            registrationPage.RegisterWithoutEmailAddress(username, password, confirmpassword, fullname, email, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterWithoutCheck", DataAccessMethod.Sequential)]
        public void RegisterWithoutCheck()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials but Without Check");
            registrationPage.RegisterWithoutTermsAndConditionsCheck(username, password, confirmpassword, fullname, email, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterWithEmptyCredientials", DataAccessMethod.Sequential)]
        public void RegisterWithEmptyCredientials()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();
            string fullname = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();
            string message5 = TestContext.DataRow["message5"].ToString();
            string message6 = TestContext.DataRow["message6"].ToString();
            string message7 = TestContext.DataRow["message7"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Empty Credentials");
            registrationPage.RegisterWithEmptyCredentials(username, password, confirmpassword, fullname, email, message2, message3, message4, message5, message6, message7);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "RegisterToRelogin", DataAccessMethod.Sequential)]
        public void RegisterToRelogin()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Register Page Through Valid Credentials and Go back to Login");
            registrationPage.ClickOnGoBackToLoginLink(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheRegisterationPageandClickOnOtherLinks", DataAccessMethod.Sequential)]
        public void VisittheRegisterationPageandClickOnOtherLinks()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Visit Registeration Page and Click On Other Links");
            registrationPage.VisitRegistrationPageAndClickOnOtherLinks();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ClickonadactinweblinkofRegistration", DataAccessMethod.Sequential)]
        public void ClickonadactinweblinkofRegistration()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Password Credientials and Click On Link New User Register Here To Click On Adactin Web Link");
            registrationPage.ClickOnAdactinWebLinkOfRegistrationPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ClickonadactinCoLinkofRegistration", DataAccessMethod.Sequential)]
        public void ClickonadactinCoLinkofRegistration()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Register Yourself");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Password Credientials and Click On Link New User Register Here To Click On Adactin Co Link");
            registrationPage.ClickOnAdactinCoLinkOfRegistrationPage();
        }
    }
}