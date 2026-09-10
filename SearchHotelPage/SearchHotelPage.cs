using AdactinWebAutomate.Core;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AdactinWebAutomate.SearchHotelPage
{
    public class SearchHotelPage : BasePage
    {
        public static By selectlocation_ = By.Id("location");
        public static By selecthotelname_ = By.Id("hotels");
        public static By selectroomtype_ = By.Id("room_type");
        public static By selectnumberofrooms_ = By.Id("room_nos");
        public static By checkindate_ = By.Id("datepick_in");
        public static By checkoutdate_ = By.Id("datepick_out");
        public static By selectadultsperroom_ = By.Id("adult_room");
        public static By selectchildrenperroom_ = By.Id("child_room");
        public static By clickonsearchhotellink_ = By.LinkText("Search Hotel");
        public static By clickonbookeditinerarylink_ = By.LinkText("Booked Itinerary");
        public static By clickonchangepasswordlink_ = By.LinkText("Change Password");
        public static By clickonsubmitbutton_ = By.Id("Submit");
        public static By clickonreset_ = By.Id("Reset");
        public static By radiobutton_ = By.Id("radiobutton_0");
        public static By clickoncontinue_ = By.Id("continue");
        public static By firstnameTXT_ = By.Id("first_name");
        public static By lastnameTXT_ = By.Id("last_name");
        public static By billingaddressTXT_ = By.Id("address");
        public static By creditcardnoTXT_ = By.Id("cc_num");
        public static By selectcreditcardtype_ = By.Id("cc_type");
        public static By selectmonth_ = By.Id("cc_exp_month");
        public static By selectyear_ = By.Id("cc_exp_year");
        public static By cvvnumberTXT_ = By.Id("cc_cvv");
        public static By clickonbooknow_ = By.Id("book_now");
        public static By clickoncancel_ = By.Id("cancel");
        public static By clickonsearchhotelbutton_ = By.CssSelector("#search_hotel");
        public static By clickonmyitinerary_ = By.CssSelector("#my_itinerary");
        public static By setupguidepdf_ = By.CssSelector("a[href*='SetupGuide.pdf']");
        public static By hoteladactinwebservice_ = By.CssSelector("a[href*='HotelAdactinWebServices']");
        public static By sampletestcaseshotelapppdf_ = By.CssSelector("a[href*='Sample-TestCases_HotelApplication.pdf']");
        public static By knowndefectshotelapppdf_ = By.CssSelector("a[href*='KnownDefects_HotelApp.pdf']");
        public static By clickonlogout_ = By.LinkText("Logout");
        public static By reloginsearchhotelpage_ = By.LinkText("Click here to login again");
        public static By adactinCoLink_ = By.LinkText("www.adactin.com");
        public static By adactinweblink_ = By.CssSelector("a[href='http://www.adactin.com']");

        public void SelectLocation(string location)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
        }

        public void SelectHotel(string location, string hotelname)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
        }

        public void SelectRoomType(string location, string hotelname, string roomtype)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
        }

        public void SelectNumberOfRooms(string location, string hotelname, string roomtype, string numberofrooms)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
            TakeScreenShot(Status.Pass, "Selecting The Number Of Rooms");
            SelectElement selectno = new SelectElement(wait.Until(d => d.FindElement(selectnumberofrooms_)));
            selectno.SelectByText(numberofrooms);
            TakeScreenShot(Status.Pass, "Number Of Rooms Selected");
        }

        public void EnterCheckInDate(string location, string hotelname, string roomtype, string numberofrooms, string checkindate)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
            TakeScreenShot(Status.Pass, "Selecting The Number Of Rooms");
            SelectElement selectno = new SelectElement(wait.Until(d => d.FindElement(selectnumberofrooms_)));
            selectno.SelectByText(numberofrooms);
            TakeScreenShot(Status.Pass, "Number Of Rooms Selected");
            TakeScreenShot(Status.Pass, "Enter The Check In Date");
            wait.Until(d => d.FindElement(checkindate_)).SendKeys(checkindate);
            TakeScreenShot(Status.Pass, "Check In Date Entered");
        }

        public void EnterCheckOutDate(string location, string hotelname, string roomtype, string numberofrooms, string checkindate, string checkoutdate)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
            TakeScreenShot(Status.Pass, "Selecting The Number Of Rooms");
            SelectElement selectno = new SelectElement(wait.Until(d => d.FindElement(selectnumberofrooms_)));
            selectno.SelectByText(numberofrooms);
            TakeScreenShot(Status.Pass, "Number Of Rooms Selected");
            TakeScreenShot(Status.Pass, "Enter The Check In Date");
            wait.Until(d => d.FindElement(checkindate_)).SendKeys(checkindate);
            TakeScreenShot(Status.Pass, "Check In Date Entered");
            TakeScreenShot(Status.Pass, "Enter The Check Out Date");
            wait.Until(d => d.FindElement(checkoutdate_)).SendKeys(checkoutdate);
            TakeScreenShot(Status.Pass, "Check Out Date Entered");
        }

        public void SelectAdultsPerRoom(string location, string hotelname, string roomtype, string numberofrooms, string checkindate, string checkoutdate, string adultsperroom)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
            TakeScreenShot(Status.Pass, "Selecting The Number Of Rooms");
            SelectElement selectno = new SelectElement(wait.Until(d => d.FindElement(selectnumberofrooms_)));
            selectno.SelectByText(numberofrooms);
            TakeScreenShot(Status.Pass, "Number Of Rooms Selected");
            TakeScreenShot(Status.Pass, "Enter The Check In Date");
            wait.Until(d => d.FindElement(checkindate_)).SendKeys(checkindate);
            TakeScreenShot(Status.Pass, "Check In Date Entered");
            TakeScreenShot(Status.Pass, "Enter Check Out Date");
            wait.Until(d => d.FindElement(checkoutdate_)).SendKeys(checkoutdate);
            TakeScreenShot(Status.Pass, "Check Out Date Entered");
            TakeScreenShot(Status.Pass, "Selecting The Adults Per Room");
            SelectElement selectadultsroom = new SelectElement(wait.Until(d => d.FindElement(selectadultsperroom_)));
            selectadultsroom.SelectByText(adultsperroom);
            TakeScreenShot(Status.Pass, "Adults Per Room Selected");
        }

        public void SelectChildrenPerRoom(string location, string hotelname, string roomtype, string numberofrooms, string checkindate, string checkoutdate, string adultsperroom, string childrenperroom)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
            TakeScreenShot(Status.Pass, "Selecting The Number Of Rooms");
            SelectElement selectno = new SelectElement(wait.Until(d => d.FindElement(selectnumberofrooms_)));
            selectno.SelectByText(numberofrooms);
            TakeScreenShot(Status.Pass, "Number Of Rooms Selected");
            TakeScreenShot(Status.Pass, "Enter The Check In Date");
            wait.Until(d => d.FindElement(checkindate_)).SendKeys(checkindate);
            TakeScreenShot(Status.Pass, "Check In Date Entered");
            TakeScreenShot(Status.Pass, "Enter Check Out Date");
            wait.Until(d => d.FindElement(checkoutdate_)).SendKeys(checkoutdate);
            TakeScreenShot(Status.Pass, "Check Out Date Entered");
            TakeScreenShot(Status.Pass, "Selecting The Adults Per Room");
            SelectElement selectadultsroom = new SelectElement(wait.Until(d => d.FindElement(selectadultsperroom_)));
            selectadultsroom.SelectByText(adultsperroom);
            TakeScreenShot(Status.Pass, "Adults Per Room Selected");
            TakeScreenShot(Status.Pass, "Selecting The Children Per Room");
            SelectElement selectchildrenroom = new SelectElement(wait.Until(d => d.FindElement(selectchildrenperroom_)));
            selectchildrenroom.SelectByText(childrenperroom);
            TakeScreenShot(Status.Pass, "Children Per Room Selected");
        }

        public void ClickOnSearchHotelLink(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonsearchhotellink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Link");
            Assert.AreEqual(message2, "Search Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ResetSearchHotelForm(string location, string hotelname, string roomtype, string numberofrooms, string checkindate, string checkoutdate, string adultsperroom, string childrenperroom)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
            TakeScreenShot(Status.Pass, "Selecting The Number Of Rooms");
            SelectElement selectno = new SelectElement(wait.Until(d => d.FindElement(selectnumberofrooms_)));
            selectno.SelectByText(numberofrooms);
            TakeScreenShot(Status.Pass, "Number Of Rooms Selected");
            TakeScreenShot(Status.Pass, "Enter The Check In Date");
            wait.Until(d => d.FindElement(checkindate_)).SendKeys(checkindate);
            TakeScreenShot(Status.Pass, "Check In Date Entered");
            TakeScreenShot(Status.Pass, "Enter Check Out Date");
            wait.Until(d => d.FindElement(checkoutdate_)).SendKeys(checkoutdate);
            TakeScreenShot(Status.Pass, "Check Out Date Entered");
            TakeScreenShot(Status.Pass, "Selecting The Adults Per Room");
            SelectElement selectadultsroom = new SelectElement(wait.Until(d => d.FindElement(selectadultsperroom_)));
            selectadultsroom.SelectByText(adultsperroom);
            TakeScreenShot(Status.Pass, "Adults Per Room Selected");
            TakeScreenShot(Status.Pass, "Selecting The Children Per Room");
            SelectElement selectchildrenroom = new SelectElement(wait.Until(d => d.FindElement(selectchildrenperroom_)));
            selectchildrenroom.SelectByText(childrenperroom);
            TakeScreenShot(Status.Pass, "Children Per Room Selected");
            wait.Until(d => d.FindElement(clickonreset_)).Click();
            TakeScreenShot(Status.Pass, "Click On Reset Button");
        }

        public void ClickOnCancelButton(string message4)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickoncancel_)).Click();
            TakeScreenShot(Status.Pass, "Click On Cancel Button");
            Assert.AreEqual(message4, "Select Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void SearchHotelAndNavigateToSearchHotelPage(string location, string hotelname, string roomtype, string numberofrooms, string checkindate, string checkoutdate, string adultsperroom, string childrenperroom, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
            TakeScreenShot(Status.Pass, "Selecting The Number Of Rooms");
            SelectElement selectno = new SelectElement(wait.Until(d => d.FindElement(selectnumberofrooms_)));
            selectno.SelectByText(numberofrooms);
            TakeScreenShot(Status.Pass, "Number Of Rooms Selected");
            TakeScreenShot(Status.Pass, "Enter The Check In Date");
            wait.Until(d => d.FindElement(checkindate_)).SendKeys(checkindate);
            TakeScreenShot(Status.Pass, "Check In Date Entered");
            TakeScreenShot(Status.Pass, "Enter Check Out Date");
            wait.Until(d => d.FindElement(checkoutdate_)).SendKeys(checkoutdate);
            TakeScreenShot(Status.Pass, "Check Out Date Entered");
            TakeScreenShot(Status.Pass, "Selecting The Adults Per Room");
            SelectElement selectadultsroom = new SelectElement(wait.Until(d => d.FindElement(selectadultsperroom_)));
            selectadultsroom.SelectByText(adultsperroom);
            TakeScreenShot(Status.Pass, "Adults Per Room Selected");
            TakeScreenShot(Status.Pass, "Selecting The Children Per Room");
            SelectElement selectchildrenroom = new SelectElement(wait.Until(d => d.FindElement(selectchildrenperroom_)));
            selectchildrenroom.SelectByText(childrenperroom);
            TakeScreenShot(Status.Pass, "Children Per Room Selected");
            wait.Until(d => d.FindElement(clickonsearchhotellink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Link");
            Assert.AreEqual(message2, "Welcome to Adactin Group of Hotels");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void SearchHotelAndNavigateToSelectHotelPage(string location, string hotelname, string roomtype, string numberofrooms, string checkindate, string checkoutdate, string adultsperroom, string childrenperroom, string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            TakeScreenShot(Status.Pass, "Selecting The Location");
            SelectElement selectlocation = new SelectElement(wait.Until(d => d.FindElement(selectlocation_)));
            selectlocation.SelectByText(location);
            TakeScreenShot(Status.Pass, "Location Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel");
            SelectElement selecthotel = new SelectElement(wait.Until(d => d.FindElement(selecthotelname_)));
            selecthotel.SelectByText(hotelname);
            TakeScreenShot(Status.Pass, "Hotel Selected");
            TakeScreenShot(Status.Pass, "Selecting The Hotel Room Type");
            SelectElement selecttype = new SelectElement(wait.Until(d => d.FindElement(selectroomtype_)));
            selecttype.SelectByText(roomtype);
            TakeScreenShot(Status.Pass, "Hotel Room Type Selected");
            TakeScreenShot(Status.Pass, "Selecting The Number Of Rooms");
            SelectElement selectno = new SelectElement(wait.Until(d => d.FindElement(selectnumberofrooms_)));
            selectno.SelectByText(numberofrooms);
            TakeScreenShot(Status.Pass, "Number Of Rooms Selected");
            TakeScreenShot(Status.Pass, "Enter The Check In Date");
            wait.Until(d => d.FindElement(checkindate_)).SendKeys(checkindate);
            TakeScreenShot(Status.Pass, "Check In Date Entered");
            TakeScreenShot(Status.Pass, "Enter Check Out Date");
            wait.Until(d => d.FindElement(checkoutdate_)).SendKeys(checkoutdate);
            TakeScreenShot(Status.Pass, "Check Out Date Entered");
            TakeScreenShot(Status.Pass, "Selecting The Adults Per Room");
            SelectElement selectadultsroom = new SelectElement(wait.Until(d => d.FindElement(selectadultsperroom_)));
            selectadultsroom.SelectByText(adultsperroom);
            TakeScreenShot(Status.Pass, "Adults Per Room Selected");
            TakeScreenShot(Status.Pass, "Selecting The Children Per Room");
            SelectElement selectchildrenroom = new SelectElement(wait.Until(d => d.FindElement(selectchildrenperroom_)));
            selectchildrenroom.SelectByText(childrenperroom);
            TakeScreenShot(Status.Pass, "Children Per Room Selected");
            wait.Until(d => d.FindElement(clickonsubmitbutton_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Button");
            Assert.AreEqual(message2, "Select Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void ClickOnOtherLinksOfSearchHotelPage()
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

        public void ClickOnAdactinCoLinkOfSearchHotelPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinCoLink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Co link");
        }

        public void ClickOnAdactinWebLinkOfSearchHotelPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(adactinweblink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Adactin Web link");
        }

        public void VerifySearchHotelPageTitle(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonsearchhotellink_)).Click();
            TakeScreenShot(Status.Pass, "Click On Search Hotel Link");
            Assert.AreEqual(message3, "Search Hotel");
            TakeScreenShot(Status.Pass, "Verify Message");
        }

        public void LogoutAndReloginToLoginPage(string message2)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(clickonlogout_)).Click();
            TakeScreenShot(Status.Pass, "Click On Logout Link");
            wait.Until(d => d.FindElement(reloginsearchhotelpage_)).Click();
            TakeScreenShot(Status.Pass, "Click On Click here to login again Link");
            Assert.AreEqual(message2, "Existing User Login - Build 1");
            TakeScreenShot(Status.Pass, "Verify Message");
        }
    }
}