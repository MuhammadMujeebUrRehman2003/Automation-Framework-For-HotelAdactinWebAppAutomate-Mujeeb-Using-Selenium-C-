using AdactinWebAutomate.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinWebAutomate.ForgotPassword
{
    [TestClass]
    public class ForgotPasswordPageTestCases : ExtentReport
    {
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        ForgotPasswordPage forgotPasswordPage = new ForgotPasswordPage();
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ForgotPasswordPageAndEnterEmail", DataAccessMethod.Sequential)]
        public void ForgotPasswordPageAndEnterEmail()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Credientials");
            loginPage.LoginWithClickHereLink(url, username, password, message, expectedErrorMessage);

            exChildTest = exParentTest.CreateNode("Visit Forgot Password Page Through Click here Link and Enter the Email");
            forgotPasswordPage.EnterEmailAndSubmitInForgotPassword(email, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitForgotPasswordPageAndReset", DataAccessMethod.Sequential)]
        public void VisitForgotPasswordPageAndReset()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();
            string email = TestContext.DataRow["email"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Credientials");
            loginPage.LoginWithClickHereLink(url, username, password, message, expectedErrorMessage);

            exChildTest = exParentTest.CreateNode("Visit Forgot Password Page and Click On Reset Button");
            forgotPasswordPage.ForgotPasswordAndReset(email);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ReloginThroughForgotPasswordPage", DataAccessMethod.Sequential)]
        public void ReloginThroughForgotPasswordPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Credientials");
            loginPage.LoginWithClickHereLink(url, username, password, message, expectedErrorMessage);

            exChildTest = exParentTest.CreateNode("Visit Forgot Password Page and Click On Relogin Link");
            forgotPasswordPage.ClickOnGoBackToLoginLinkInForgotPassword(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ClickOnOtherlinksOfForgotPasswordPage", DataAccessMethod.Sequential)]
        public void ClickOnOtherlinksOfForgotPasswordPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Credientials");
            loginPage.LoginWithClickHereLink(url, username, password, message, expectedErrorMessage);

            exChildTest = exParentTest.CreateNode("Visit the Other Links Of Forgot Password Page");
            forgotPasswordPage.ClickOnOtherLinksOfForgotPasswordPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ClickonadactinweblinkofForgotPasswordPage", DataAccessMethod.Sequential)]
        public void ClickonadactinweblinkofForgotPasswordPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Credientials");
            loginPage.LoginWithClickHereLink(url, username, password, message, expectedErrorMessage);

            exChildTest = exParentTest.CreateNode("Visit the Forgot Password Page and Click On Adactin Web Link Of Forgot Password");
            forgotPasswordPage.ClickOnAdactinWebLinkOfForgotPasswordPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ClickonAdactinCoLinkofForgotPasswordPage", DataAccessMethod.Sequential)]
        public void ClickonAdactinCoLinkofForgotPasswordPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Credientials");
            loginPage.LoginWithClickHereLink(url, username, password, message, expectedErrorMessage);

            exChildTest = exParentTest.CreateNode("Visit the Forgot Password Page and Click On Adactin CO Link Of Forgot Password");
            forgotPasswordPage.ClickOnAdactinCoLinkOfForgotPasswordPage();
        }
    }
}