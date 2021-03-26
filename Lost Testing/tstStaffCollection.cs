using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartClasses;


namespace Lost_Testing
{
    [TestClass]
    

    public class tstStaffCollection

    {
        [TestMethod]
        public void InstanceOK()
        {

            clsStaffCollection AllStaff = new clsStaffCollection();

            Assert.IsNotNull(AllStaff);


        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();

            TestItem.StaffIDNo = 1;
            TestItem.StaffName = "Atender";
            TestItem.StaffDOB = DateTime.Now.Date;
            TestItem.StaffEmail = "Pooni1212@hotmail.com";
            TestItem.AddressID = 1;
            TestItem.StaffTelNo = 1234145;

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.StaffList, TestList);




        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            Int32 SomeCount = 2;

            AllStaff.Count = SomeCount;

            Assert.AreEqual(AllStaff.Count, SomeCount);





        }

        [TestMethod]
        public void ThisStaffProprtyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestStaff = new clsStaff();

            TestStaff.StaffIDNo = 1;
            TestStaff.StaffName = "Atender";
            TestStaff.StaffDOB = DateTime.Now.Date;
            TestStaff.StaffEmail = "Pooni1212@hotmail.com";
            TestStaff.AddressID = 12;
            TestStaff.StaffTelNo = 1234145;

            AllStaff.ThisStaff = TestStaff;

            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);



        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            Assert.AreEqual(AllStaff.Count, 2);




        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffIDNo = 1;
            TestItem.StaffName = "Atender";
            TestItem.StaffDOB = DateTime.Now.Date;
            TestItem.StaffEmail = "Pooni1212@hotmail.com";
            TestItem.AddressID = 12;
            TestItem.StaffTelNo = 1234145;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StaffIDNo = PrimaryKey;

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);




        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffIDNo = 1;
            TestItem.StaffName = "Atender";
            TestItem.StaffDOB = DateTime.Now.Date;
            TestItem.StaffEmail = "Pooni1212@hotmail.com";
            TestItem.AddressID = 12;
            TestItem.StaffTelNo = 1234145;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StaffIDNo = PrimaryKey;

            AllStaff.ThisStaff.Find(PrimaryKey);

            AllStaff.Delete();

            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);


            Assert.IsFalse(Found);




        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffIDNo = 1;
            TestItem.StaffName = "Atender";
            TestItem.StaffDOB = DateTime.Now.Date;
            TestItem.StaffEmail = "Pooni1212@hotmail.com";
            TestItem.AddressID = 12;
            TestItem.StaffTelNo = 1234145;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StaffIDNo = PrimaryKey;

            TestItem.StaffIDNo = 1;
            TestItem.StaffName = "Atender";
            TestItem.StaffDOB = DateTime.Now.Date;
            TestItem.StaffEmail = "Pooni1212@hotmail.com";
            TestItem.AddressID = 12;
            TestItem.StaffTelNo = 1234145;

            AllStaff.ThisStaff = TestItem;

            AllStaff.Update();

            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);








        }
    }
}
