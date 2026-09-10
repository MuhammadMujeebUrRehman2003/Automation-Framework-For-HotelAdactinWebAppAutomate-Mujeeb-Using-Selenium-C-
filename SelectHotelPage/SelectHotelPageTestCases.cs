using AdactinWebAutomate.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinWebAutomate.SelectHotelPage
{
    [TestClass]
    public class SelectHotelPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        SearchHotelPage.SearchHotelPage searchhotelPage = new SearchHotelPage.SearchHotelPage();
        SelectHotelPage selectHotelPage = new SelectHotelPage();

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectTheHotelandClickonRadioButton", DataAccessMethod.Sequential)]
        public void SelectTheHotelandClickonRadioButton()
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

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit the Search Hotel Page and Click On Search Button");
            selectHotelPage.SelectHotelAndClickRadioButton();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SelectHotelToContinue", DataAccessMethod.Sequential)]
        public void SelectHotelToContinue()
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

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndContinue(message3);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "CancelHotel", DataAccessMethod.Sequential)]
        public void CancelHotel()
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

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Cancel Button");
            selectHotelPage.SelectHotelAndCancel(message3);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "CancelHotelBooking", DataAccessMethod.Sequential)]
        public void CancelHotelBooking()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select Hotel Page and Click On Continue Button");
            selectHotelPage.SelectHotelAndCancelBooking(message3);

            exChildTest = exParentTest.CreateNode("Then Enter The Credientials and Click On Cancel Button");
            searchhotelPage.ClickOnCancelButton(message4);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitSelectTheHotelPageandClickOnSearchHotel", DataAccessMethod.Sequential)]
        public void VisitSelectTheHotelPageandClickOnSearchHotel()
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

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credentials");
            loginPage.LoginWithValidCredentials(url, username, password, message);

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Search Hotel and Click On Search Hotel Link");
            selectHotelPage.ClickOnSearchHotelLink(message3);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitSelectTheHotelPageandClickOnOtherLinks", DataAccessMethod.Sequential)]
        public void VisitSelectTheHotelPageandClickOnOtherLinks()
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

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select The Hotel Page and Click On Other Links");
            selectHotelPage.ClickOnOtherLinksOfSelectHotelPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitSelectTheHotelPageandClickonadactinWebLink", DataAccessMethod.Sequential)]
        public void VisitSelectTheHotelPageandClickonadactinWebLink()
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

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select The Hotel Page and Click On Adactin Web Link");
            selectHotelPage.ClickOnAdactinWebLinkOfSelectHotelPage();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "VisitSelectTheHotelPageandClickonadactinCoLink", DataAccessMethod.Sequential)]
        public void VisitSelectTheHotelPageandClickonadactinCoLink()
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

            exChildTest = exParentTest.CreateNode("Visit the Select Hotel Page");
            searchhotelPage.SearchHotelAndNavigateToSelectHotelPage(location, hotelname, roomtype, numberofrooms, checkInDate, checkoutdate, adultsperroom, childrenperroom, message2);

            exChildTest = exParentTest.CreateNode("Visit Select The Hotel Page and Click On Adactin Co Link");
            selectHotelPage.ClickOnAdactinCoLinkOfSelectHotelPage();
        }
    }
}