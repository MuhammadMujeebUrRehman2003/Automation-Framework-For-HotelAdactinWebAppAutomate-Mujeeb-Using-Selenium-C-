using AdactinWebAutomate.BookedItineraryPage;
using AdactinWebAutomate.BookHotelPage;
using AdactinWebAutomate.BookingConfirmationPage;
using AdactinWebAutomate.Core;
using AdactinWebAutomate.SelectHotelPage;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinWebAutomate.ChangePasswordPage
{
    [TestClass]
    public class ChangePasswordPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        SearchHotelPage.SearchHotelPage searchhotelPage = new SearchHotelPage.SearchHotelPage();
        SelectHotelPage.SelectHotelPage selectHotelPage = new SelectHotelPage.SelectHotelPage();
        BookHotelPage.BookHotelPage bookhotelpage = new BookHotelPage.BookHotelPage();
        BookedItineraryPage.BookedItineraryPage bookedItineraryPage = new BookedItineraryPage.BookedItineraryPage();
        ChangePasswordPage changePasswordPage = new ChangePasswordPage();

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheSearchHotelPageandClickOnChangePassword", DataAccessMethod.Sequential)]
        public void VisittheSearchHotelPageandClickOnChangePassword()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string currentpassword = TestContext.DataRow["currentpassword"].ToString();
            string newpassword = TestContext.DataRow["newpassword"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Change Password Link");
            changePasswordPage.ClickOnChangePasswordLinkFromSearchHotelPage(message2, currentpassword, newpassword, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitSelectTheHotelPageandClickOnChangePassword", DataAccessMethod.Sequential)]
        public void VisitSelectTheHotelPageandClickOnChangePassword()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string location = TestContext.DataRow["location"].ToString();
            string hotelname = TestContext.DataRow["hotelname"].ToString();
            string roomtype = TestContext.DataRow["roomtype"].ToString();
            string numberofrooms = TestContext.DataRow["numberofrooms"].ToString();
            string checkInDate = TestContext.DataRow["checkindate"].ToString();
            string checkoutdate = TestContext.DataRow["checkoutdate"].ToString();
            string adultsperroom = TestContext.DataRow["adultsperroom"].ToString();
            string childrenperroom = TestContext.DataRow["childrenperroom"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string currentpassword = TestContext.DataRow["currentpassword"].ToString();
            string newpassword = TestContext.DataRow["newpassword"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select The Hotel Page and Click On Change Password Link");
            changePasswordPage.ClickOnChangePasswordLinkFromSelectHotelPage(message3, currentpassword, newpassword, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitBookHotelPageandClickOnChangePassword", DataAccessMethod.Sequential)]
        public void VisitBookHotelPageandClickOnChangePassword()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string location = TestContext.DataRow["location"].ToString();
            string hotelname = TestContext.DataRow["hotelname"].ToString();
            string roomtype = TestContext.DataRow["roomtype"].ToString();
            string numberofrooms = TestContext.DataRow["numberofrooms"].ToString();
            string checkInDate = TestContext.DataRow["checkindate"].ToString();
            string checkoutdate = TestContext.DataRow["checkoutdate"].ToString();
            string adultsperroom = TestContext.DataRow["adultsperroom"].ToString();
            string childrenperroom = TestContext.DataRow["childrenperroom"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();
            string currentpassword = TestContext.DataRow["currentpassword"].ToString();
            string newpassword = TestContext.DataRow["newpassword"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credentials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Book Hotel and Click On Change Password Link");
            changePasswordPage.ClickOnChangePasswordLinkFromBookHotelPage(message4, currentpassword, newpassword, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitBookingConfirmationPageandClickOnChangePassword", DataAccessMethod.Sequential)]
        public void VisitBookingConfirmationPageandClickOnChangePassword()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string location = TestContext.DataRow["location"].ToString();
            string hotelname = TestContext.DataRow["hotelname"].ToString();
            string roomtype = TestContext.DataRow["roomtype"].ToString();
            string numberofrooms = TestContext.DataRow["numberofrooms"].ToString();
            string checkInDate = TestContext.DataRow["checkindate"].ToString();
            string checkoutdate = TestContext.DataRow["checkoutdate"].ToString();
            string adultsperroom = TestContext.DataRow["adultsperroom"].ToString();
            string childrenperroom = TestContext.DataRow["childrenperroom"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string billingaddress = TestContext.DataRow["billingaddress"].ToString();
            string creditcardno = TestContext.DataRow["creditcardno"].ToString();
            string creditcardtype = TestContext.DataRow["creditcardtype"].ToString();
            string month = TestContext.DataRow["month"].ToString();
            string year = TestContext.DataRow["year"].ToString();
            string cvvnumber = TestContext.DataRow["cvvnumber"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();
            string message5 = TestContext.DataRow["message5"].ToString();
            string currentpassword = TestContext.DataRow["currentpassword"].ToString();
            string newpassword = TestContext.DataRow["newpassword"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credentials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On Book Now Button");
            bookhotelpage.BookHotel(firstname, lastname, billingaddress, creditcardno, creditcardtype, month, year, cvvnumber, message4);

            exChildTest = exParentTest.CreateNode("Complete Booking and Click On Change Password Link");
            changePasswordPage.ClickOnChangePasswordLinkFromBookingConfirmationPage(message5, currentpassword, newpassword, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheBookItineraryPageandClickOnChangePassword", DataAccessMethod.Sequential)]
        public void VisittheBookItineraryPageandClickOnChangePassword()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string currentpassword = TestContext.DataRow["currentpassword"].ToString();
            string newpassword = TestContext.DataRow["newpassword"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Book Itinerary Page");
            bookedItineraryPage.ClickOnBookedItineraryLinkFromSearchHotelPage(message2);

            exChildTest = exParentTest.CreateNode("Visit the Book Itinerary Page and Click On Change Password Link");
            changePasswordPage.ClickOnChangePasswordLinkFromBookedItineraryPage(message3, currentpassword, newpassword, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheChangePasswordPageandClickOnSearchHotel", DataAccessMethod.Sequential)]
        public void VisittheChangePasswordPageandClickOnSearchHotel()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Change Password Page");
            changePasswordPage.ClickOnChangePasswordLink(message2);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page");
            searchhotelPage.VerifySearchHotelPageTitle(message3);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheChangePasswordPageandClickOnOtherLinks", DataAccessMethod.Sequential)]
        public void VisittheChangePasswordPageandClickOnOtherLinks()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Change Password Page and Click On Other Links");
            changePasswordPage.ClickOnChangePasswordAndOtherLinks(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheChangePasswordPageandClickOnChangePassword", DataAccessMethod.Sequential)]
        public void VisittheChangePasswordPageandClickOnChangePassword()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string currentpassword = TestContext.DataRow["currentpassword"].ToString();
            string newpassword = TestContext.DataRow["newpassword"].ToString();
            string confirmpassword = TestContext.DataRow["confirmpassword"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Change Password Page and Change Password");
            changePasswordPage.ChangePasswordFromChangePasswordPage(message2, currentpassword, newpassword, confirmpassword);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheChangePasswordPageandClickonadactinWebLink", DataAccessMethod.Sequential)]
        public void VisittheChangePasswordPageandClickonadactinWebLink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Change Password Page and Click On Adactin Web Link");
            changePasswordPage.ClickOnAdactinWebLinkFromChangePasswordPage(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheChangePasswordPageandClickonadactinCoLink", DataAccessMethod.Sequential)]
        public void VisittheChangePasswordPageandClickonadactinCoLink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Change Password Page and Click On Adactin Co Link");
            changePasswordPage.ClickOnAdactinCoLinkFromChangePasswordPage(message2);
        }
    }
}