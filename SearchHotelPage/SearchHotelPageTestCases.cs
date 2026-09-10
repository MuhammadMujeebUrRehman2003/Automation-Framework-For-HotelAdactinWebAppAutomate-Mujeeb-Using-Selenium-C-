using AdactinWebAutomate.BookHotelPage;
using AdactinWebAutomate.Core;
using AdactinWebAutomate.SelectHotelPage;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinWebAutomate.SearchHotelPage
{
    [TestClass]
    public class SearchHotelPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        SelectHotelPage.SelectHotelPage selectHotelPage = new SelectHotelPage.SelectHotelPage();
        BookHotelPage.BookHotelPage bookHotelPage = new BookHotelPage.BookHotelPage();
        SearchHotelPage searchhotelPage = new SearchHotelPage();

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectLocation", DataAccessMethod.Sequential)]
        public void SelectLocation()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string location = TestContext.DataRow["location"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Hotel Page and Select Location");
            searchhotelPage.SelectLocation(location);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectHotel", DataAccessMethod.Sequential)]
        public void SelectHotel()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string location = TestContext.DataRow["location"].ToString();
            string hotelname = TestContext.DataRow["hotelname"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Hotel Page and Select Hotel");
            searchhotelPage.SelectHotel(location, hotelname);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectRoomType", DataAccessMethod.Sequential)]
        public void SelectRoomType()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string location = TestContext.DataRow["location"].ToString();
            string hotelname = TestContext.DataRow["hotelname"].ToString();
            string roomtype = TestContext.DataRow["roomtype"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Hotel Page and Select Room Type");
            searchhotelPage.SelectRoomType(location, hotelname, roomtype);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectNumberOfRooms", DataAccessMethod.Sequential)]
        public void SelectNumberOfRooms()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string location = TestContext.DataRow["location"].ToString();
            string hotelname = TestContext.DataRow["hotelname"].ToString();
            string roomtype = TestContext.DataRow["roomtype"].ToString();
            string numberofrooms = TestContext.DataRow["numberofrooms"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Hotel Page and Select Number Of Rooms");
            searchhotelPage.SelectNumberOfRooms(location, hotelname, roomtype, numberofrooms);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "CheckInDate", DataAccessMethod.Sequential)]
        public void CheckInDate()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Hotel Page and Enter Check In Date");
            searchhotelPage.EnterCheckInDate(location, hotelname, roomtype, numberofrooms, checkInDate);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "CheckOutDate", DataAccessMethod.Sequential)]
        public void CheckOutDate()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Hotel Page and Enter Check Out Date");
            searchhotelPage.EnterCheckOutDate(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectAdultsPerRoom", DataAccessMethod.Sequential)]
        public void SelectAdultsPerRoom()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Hotel Page and Select Adults Per Room");
            searchhotelPage.SelectAdultsPerRoom(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectChildrenPerRoom", DataAccessMethod.Sequential)]
        public void SelectChildrenPerRoom()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Hotel Page and Select Children Per Room");
            searchhotelPage.SelectChildrenPerRoom(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheSearchHotelPage", DataAccessMethod.Sequential)]
        public void VisittheSearchHotelPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page");
            searchhotelPage.ClickOnSearchHotelLink(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ResetForm", DataAccessMethod.Sequential)]
        public void ResetForm()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Reset Button");
            searchhotelPage.ResetSearchHotelForm(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectTheHotel", DataAccessMethod.Sequential)]
        public void SelectTheHotel()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Search Button");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheSearchHotelPageandClickOnOtherLinks", DataAccessMethod.Sequential)]
        public void VisittheSearchHotelPageandClickOnOtherLinks()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search Page and Click On Other Links");
            searchhotelPage.ClickOnOtherLinksOfSearchHotelPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheSearchHotelPageandClickonadactinCoLink", DataAccessMethod.Sequential)]
        public void VisittheSearchHotelPageandClickonadactinCoLink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search page and Click on Adactin Co link");
            searchhotelPage.ClickOnAdactinCoLinkOfSearchHotelPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisittheSearchHotelPageandClickonadactinWebLink", DataAccessMethod.Sequential)]
        public void VisittheSearchHotelPageandClickonadactinWebLink()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit Search page and Click on Adactin Web links");
            searchhotelPage.ClickOnAdactinWebLinkOfSearchHotelPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SearchHotel", DataAccessMethod.Sequential)]
        public void SearchHotel()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSearchHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SearchingHotel", DataAccessMethod.Sequential)]
        public void SearchingHotel()
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

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On Book Now Button");
            bookHotelPage.BookHotel(firstname, lastname, billingaddress, creditcardno, creditcardtype, month, year, cvvnumber, message4);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button Then Enter The Credientials and Click On Book Now Button and Then Click On Search Hotel Button");
            selectHotelPage.ClickOnSearchHotelButton(message5);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "ReloginTheLoginPage", DataAccessMethod.Sequential)]
        public void ReloginTheLoginPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message1);

            exChildTest = exParentTest.CreateNode("Relogin The Login Page");
            searchhotelPage.LogoutAndReloginToLoginPage(message2);
        }
    }
}