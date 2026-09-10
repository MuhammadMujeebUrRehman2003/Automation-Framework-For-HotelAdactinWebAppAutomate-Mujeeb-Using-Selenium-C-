using AdactinWebAutomate.BookHotelPage;
using AdactinWebAutomate.Core;
using AdactinWebAutomate.SelectHotelPage;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinWebAutomate.MyItineraryPage
{
    [TestClass]
    public class MyItineraryPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        SearchHotelPage.SearchHotelPage searchhotelPage = new SearchHotelPage.SearchHotelPage();
        SelectHotelPage.SelectHotelPage selectHotelPage = new SelectHotelPage.SelectHotelPage();
        BookHotelPage.BookHotelPage bookHotelPage = new BookHotelPage.BookHotelPage();
        MyItineraryPage myItineraryPage = new MyItineraryPage();

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "MyItinerarySearchThroughOrderId", DataAccessMethod.Sequential)]
        public void MyItinerarySearchThroughOrderId()
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

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Search Button");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On Book Now Button");
            bookHotelPage.BookHotel(firstname, lastname, billingaddress, creditcardno, creditcardtype, month, year, cvvnumber, message4);

            exChildTest = exParentTest.CreateNode("Complete Booking and Search Through Order ID");
            myItineraryPage.ClickOnMyItineraryAndSearchThroughOrderId(message5);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "MyItinerarySearchHotel", DataAccessMethod.Sequential)]
        public void MyItinerarySearchHotel()
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

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Search Button");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On Book Now Button");
            bookHotelPage.BookHotel(firstname, lastname, billingaddress, creditcardno, creditcardtype, month, year, cvvnumber, message4);

            exChildTest = exParentTest.CreateNode("Complete Booking and Search Hotel from My Itinerary");
            myItineraryPage.ClickOnMyItineraryAndSearchHotel(message5);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "MyItineraryLogout", DataAccessMethod.Sequential)]
        public void MyItineraryLogout()
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

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Search Button");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On Book Now Button");
            bookHotelPage.BookHotel(firstname, lastname, billingaddress, creditcardno, creditcardtype, month, year, cvvnumber, message4);

            exChildTest = exParentTest.CreateNode("Complete Booking and Logout from My Itinerary");
            myItineraryPage.ClickOnMyItineraryAndLogout(message5);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "MyItineraryCancelSelection", DataAccessMethod.Sequential)]
        public void MyItineraryCancelSelection()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credentials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Search Button");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Complete Booking and Cancel Selection");
            myItineraryPage.ClickOnMyItineraryAndCancelSelection(firstname, lastname, billingaddress, creditcardno, creditcardtype, month, year, cvvnumber, message4);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "MyItinerary", DataAccessMethod.Sequential)]
        public void MyItinerary()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Search Button");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On Book Now Button");
            bookHotelPage.BookHotel(firstname, lastname, billingaddress, creditcardno, creditcardtype, month, year, cvvnumber, message4);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On My Itinerary Button");
            myItineraryPage.ClickOnMyItineraryButton(message5);
        }
    }
}