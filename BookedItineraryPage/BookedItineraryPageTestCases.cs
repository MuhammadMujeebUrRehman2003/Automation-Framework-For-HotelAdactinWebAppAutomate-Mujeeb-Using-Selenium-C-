using AdactinWebAutomate.BookHotelPage;
using AdactinWebAutomate.BookingConfirmationPage;
using AdactinWebAutomate.ChangePasswordPage;
using AdactinWebAutomate.Core;
using AdactinWebAutomate.SelectHotelPage;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinWebAutomate.BookedItineraryPage
{
    [TestClass]
    public class BookedItineraryPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        SearchHotelPage.SearchHotelPage searchhotelPage = new SearchHotelPage.SearchHotelPage();
        SelectHotelPage.SelectHotelPage selectHotelPage = new SelectHotelPage.SelectHotelPage();
        BookHotelPage.BookHotelPage bookhotelpage = new BookHotelPage.BookHotelPage();
        MyItineraryPage.MyItineraryPage myItineraryPage = new MyItineraryPage.MyItineraryPage();
        ChangePasswordPage.ChangePasswordPage changePasswordPage = new ChangePasswordPage.ChangePasswordPage();
        BookedItineraryPage bookedItineraryPage = new BookedItineraryPage();

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheSearchHotelPageandClickOnBookItinerary", DataAccessMethod.Sequential)]
        public void VisittheSearchHotelPageandClickOnBookItinerary()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Book Itinerary Link");
            bookedItineraryPage.ClickOnBookedItineraryLinkFromSearchHotelPage(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitSelectTheHotelPageandClickOnBookItinerary", DataAccessMethod.Sequential)]
        public void VisitSelectTheHotelPageandClickOnBookItinerary()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select The Hotel Page and Click On Book Itinerary Link");
            bookedItineraryPage.ClickOnBookedItineraryLinkFromSelectHotelPage(message3);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitBookHotelPageandClickOnBookItinerary", DataAccessMethod.Sequential)]
        public void VisitBookHotelPageandClickOnBookItinerary()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credentials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Book Hotel and Click On Book Itinerary Link");
            bookedItineraryPage.ClickOnBookedItineraryLinkFromBookHotelPage(message4);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitBookingConfirmationPageandClickOnBookItinerary", DataAccessMethod.Sequential)]
        public void VisitBookingConfirmationPageandClickOnBookItinerary()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credentials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On Book Now Button");
            bookhotelpage.BookHotel(firstname, lastname, billingaddress, creditcardno, creditcardtype, month, year, cvvnumber, message4);

            exChildTest = exParentTest.CreateNode("Complete Booking and Click On Book Itinerary Button");
            bookedItineraryPage.ClickOnBookedItineraryLinkFromBookingConfirmationPage(message5);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheBookItineraryPageandClickOnSearchHotel", DataAccessMethod.Sequential)]
        public void VisittheBookItineraryPageandClickOnSearchHotel()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Book Itinerary Page");
            myItineraryPage.VisitMyItineraryPage(message2);

            exChildTest = exParentTest.CreateNode("Click On Search Hotel Link");
            bookedItineraryPage.ClickOnSearchHotelLinkFromBookedItineraryPage(message3);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheBookItineraryPageandClickOnBookItinerary", DataAccessMethod.Sequential)]
        public void VisittheBookItineraryPageandClickOnBookItinerary()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Book Itinerary Page and Click On Book Itinerary Link");
            bookedItineraryPage.ClickOnBookedItineraryLinkFromBookedItineraryPage(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheChangePasswordPageandClickOnBookItinerary", DataAccessMethod.Sequential)]
        public void VisittheChangePasswordPageandClickOnBookItinerary()
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

            exChildTest = exParentTest.CreateNode("Click On Book Itinerary Link");
            bookedItineraryPage.ClickOnBookedItineraryLinkFromBookHotelPage(message3);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheBookItineraryPageandClickonadactinWebLink", DataAccessMethod.Sequential)]
        public void VisittheBookItineraryPageandClickonadactinWebLink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Book Itinerary Page and Click On Adactin Web Link");
            bookedItineraryPage.ClickOnAdactinWebLinkFromBookedItineraryPage(message2);
        }
    }
}