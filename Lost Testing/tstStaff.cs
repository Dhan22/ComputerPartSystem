using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartClasses;



namespace Test_Framework
{
    [TestClass]
    public class tstAddress
    {
        string StaffName = "Atender";
        string StaffEmail = "pooni1212@hgotmailc.om";
        string StaffDOB = DateTime.Now.Date.ToString();
        string StaffTelNo = "0891233";
        string AddressID = "234";






        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }


        [TestMethod]
        public void StaffIDNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffIDNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffIDNo, TestData);
        }

        [TestMethod]
        public void StaffTelNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 94819842;
            //assign the data to the property
            AnStaff.StaffTelNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffTelNo, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Pooni1212@hotrmai.com";
            //assign the data to the property
            AnStaff.StaffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Harry";
            //assign the data to the property
            AnStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffName, TestData);
        }


        [TestMethod]
        public void StaffDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.StaffDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffDOB, TestData);
        }

        [TestMethod]
        public void AddressIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1231;
            //assign the data to the property
            AnStaff.AddressID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.AddressID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean Found = false;
            //assign the data to the property
            Int32 StaffIDNo = 1;
            //test to see that the two values are the same
            Found = AnStaff.Find(StaffIDNo);

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean Found = false;
            //assign the data to the property
            Boolean OK = true;

            Int32 StaffIDNo = 20;
            //test to see that the two values are the same
            Found = AnStaff.Find(StaffIDNo);

            if (AnStaff.StaffIDNo != 20)
            {
                OK = false;
            }

            

        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffIDNo = 20;
            //invoke the method
            Found = AnStaff.Find(StaffIDNo);
            //check the property
            if (AnStaff.StaffName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffIDNo = 20;
            //invoke the method
            Found = AnStaff.Find(StaffIDNo);
            //check the property
            if (AnStaff.StaffEmail != "Test Email")
            {
                OK = false;
            }
            //test to see that the result is correct
            
        }

        [TestMethod]
        public void TestStaffIDNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffIDNo = 20;
            //invoke the method
            Found = AnStaff.Find(StaffIDNo);
            //check the address no
            if (AnStaff.StaffIDNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffIDNo = 21;
            //invoke the method
            Found = AnStaff.Find(StaffIDNo);
            //check the property
            if (AnStaff.StaffDOB != Convert.ToDateTime("16/09/1992"))
            {
                OK = false;
            }
            //test to see that the result is correct
            
        }

        [TestMethod]
        public void TestStaffTelNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffIDNo = 20;
            //invoke the method
            Found = AnStaff.Find(StaffIDNo);
            //check the address no
            if (AnStaff.StaffTelNo != 21234424)
            {
                OK = false;
            }
            //test to see that the result is correct
            

        }
        [TestMethod]
        public void TestAddressIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffIDNo = 21;
            //invoke the method
            Found = AnStaff.Find(StaffIDNo);
            //check the property
            if (AnStaff.StaffName != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String Error = "";
            //assign the data to the property
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the two values are the same
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String Error = "";

            string StaffName = "";
            //assign the data to the property
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]

        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "aaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        public void StaffTelNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNo = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNo = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffTelNoMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffTelNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNo = "aaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






















        [TestMethod]

        public void StaffDOBInvalidData()
        {

            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string StaffDOB = "this is not a date";

            Error = AnStaff.Valid(StaffName, StaffEmail, StaffDOB, StaffTelNo, AddressID);

            Assert.AreNotEqual(Error, "");


        }



    }
}



