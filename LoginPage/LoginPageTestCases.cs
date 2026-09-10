using AdactinWebAutomate.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Windows.Forms;

namespace AdactinWebAutomate.LoginPage
{
    [TestClass]
    public class LoginPageTestCases : ExtentReport
    {
        LoginPage loginPage = new LoginPage();
        BasePage basePage = new BasePage();

        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            string ResultFilePath = @"C:\Users\Administrator\source\repos\Automation-Framework-For-HotelAdactinWebAppAutomate-Mujeeb-Using-Selenium-C#\ExtentReports\TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html";
            CreateReport(ResultFilePath);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            MessageBox.Show("Assembly CleanUp");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            MessageBox.Show("Class Initialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            MessageBox.Show("Class CleanUp");
        }

        [TestInitialize]
        public void Setup()
        {
            loginPage.SeleniumInit();
            exParentTest = extentReports.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void TearDown()
        {
            loginPage.DriverClose();
            extentReports.Flush();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginWithValidCredientials", DataAccessMethod.Sequential)]
        public void LoginWithValidCredientials()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginWithInvalidUsernameandPasswordCredientials", DataAccessMethod.Sequential)]
        public void LoginWithInvalidUsernameandPasswordCredientials()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Username and Password Credientials");
            loginPage.LoginWithInvalidUsernameAndPasswordCredentials(url, username, password, expectedErrorMessage);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginWithInvalidUsernameCredientials", DataAccessMethod.Sequential)]
        public void LoginWithInvalidUsernameCredientials()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string UsernameErrorMessage = TestContext.DataRow["Errormessage"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Username Credientials");
            loginPage.LoginWithInvalidUsernameCredentials(url, username, password, UsernameErrorMessage);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginWithInvalidPasswordCredientials", DataAccessMethod.Sequential)]
        public void LoginWithInvalidPasswordCredientials()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Password Credientials");
            loginPage.LoginWithInvalidPasswordCredentials(url, username, password, expectedErrorMessage);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginWithInvalidUsernameandPasswordandClickOnClickherelink", DataAccessMethod.Sequential)]
        public void LoginWithInvalidUsernameandPasswordandClickOnClickherelink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string expectedErrorMessage = TestContext.DataRow["Errormessage"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Username and Password and Click On Click here link Credientials");
            loginPage.LoginWithClickHereLink(url, username, password, message, expectedErrorMessage);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ClickOnNewUserRegisterherelink", DataAccessMethod.Sequential)]
        public void ClickOnNewUserRegisterherelink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Visit Login Page and Click On New User Register Here Link");
            loginPage.ClickOnNewUserRegisterHereLink(url, message);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginWithEmptyCredientials", DataAccessMethod.Sequential)]
        public void LoginWithEmptyCredientials()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string UsernameErrorMessage = TestContext.DataRow["Errormessage"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Empty Credientials");
            loginPage.LoginWithEmptyCredentials(url, username, password, UsernameErrorMessage);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginPageGotoBuild2", DataAccessMethod.Sequential)]
        public void LoginPageGotoBuild2()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Visit Login Page and Click On Go To Login Page Build 2 Link");
            loginPage.LoginPageGoToBuild2(url, username, password, message);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginPageMailToAdactin", DataAccessMethod.Sequential)]
        public void LoginPageMailToAdactin()
        {
            string url = TestContext.DataRow["url"].ToString();

            exChildTest = exParentTest.CreateNode("Visit Login Page and Click On Mail To Adactin Link");
            loginPage.LoginPageMailToAdactin(url);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginPageIosLink", DataAccessMethod.Sequential)]
        public void LoginPageIosLink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Visit Login Page and Click On Go To Login Page ios App Link");
            loginPage.LoginPageIosLink(url, message);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginPageAppStoreLink", DataAccessMethod.Sequential)]
        public void LoginPageAppStoreLink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Visit Login Page and Click On Go To Login Page Google App Store Link");
            loginPage.LoginPageAppStoreLink(url, message);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ClickOnLoginPageAdactinCoLink", DataAccessMethod.Sequential)]
        public void ClickOnLoginPageAdactinCoLink()
        {
            string url = TestContext.DataRow["url"].ToString();

            exChildTest = exParentTest.CreateNode("Visit Login Page and Click On Go To Login Page Adactin CO Link");
            loginPage.ClickOnLoginPageAdactinCoLink(url);
        }
    }
}