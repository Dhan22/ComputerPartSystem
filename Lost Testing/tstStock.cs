using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartClasses;

namespace Test_Framework
{

    [TestClass]

    public class tstStock
    {
        //good test data 
        //create some test data to pass the method 
        string PCName = "Dell";
        string RAM = "12";
        string CPU = "AMD";
        string GPU = "Dell";
        string BuildDate = "10/03/2011";
        string StockAvaliable = "4";
        string StorageType = "2";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void BuildDateOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

        }

        [TestMethod]
        public void GPUOK()
        {
            //create an instance of the class ws want to create
            clsStock AnStock = new clsStock();
            //some test data to assign to the property
            string TestData = "intel";
            //assign the data to the property
            AnStock.GPU = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnStock.GPU, TestData);

        }

        [TestMethod]
        public void PCIDNO()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 12456;
            //assigning the data to the property
            AnStock.PCIDNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.PCIDNo, TestData);
        }

        [TestMethod]
        public void PCNameOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //some test data to assign to the property
            string TestData = " intel";
            //assign the data to the property
            AnStock.PCName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnStock.PCName, TestData);

        }

        [TestMethod]
        public void RAMOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();

        }

        [TestMethod]
        public void StockAvalibleOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();


        }

        [TestMethod]
        public void StorageTypeOk()
        {
            //create an instance of the class we want to create

        }


        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //test tp see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestPCIDNoFound()
        {
            //create a instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is Ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PCIDNo = 21;
            //invoke the method
            Found = AnStock.Find(PCIDNo);
            //check the PCIDNo 
            if (AnStock.PCIDNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestBuildDateFound()
        {
            //create an instance of the calss we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is Ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //check the property 
            if (AnStock.Builddate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void PCIDNoOk()
        {
            //create an instanc ef the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the validaition 
            Boolean Found = false;
            // create some test data to use with the method
            Int32 PCIDNo = 1;
            //invoke the method 
            Found = AnStock.Find(PCIDNo);
            //test to see the result is correct
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestPCNameFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean cariable to recorf if data is Ok
            Boolean OK = true;
            //create some data to use with the method
            Int32 PCIDNo = 21;
            //invoke the method 
            Found = AnStock.Find(PCIDNo);
            //check the property 
            if (AnStock.PCName != Convert.ToString("Intel"))
            {


                OK = false;



            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestRAMFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean cariable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to sue with teh method
            Int32 PCIDNo = 21;
            //invoke the method 
            Found = AnStock.Find(PCIDNo);
            //check the property 
            if (AnStock.RAM != Convert.ToInt32("64GB"))
            {
                OK = false;
            }
            //test to see that the reuslt is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCPUFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with teh method 
            Int32 StockNo = 21;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //check the property 
            if (AnStock.CPU != "Test CPU")
            {
                OK = false;
            }
            //test to see that the reuslt is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestGPUFound()
        {
            //create an instance of the calss we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store hte result of the search 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with teh method 
            Int32 StockNo = 21;
            //invoke the method 
            Found = AnStock.Find(StockNo);
            //check the property 
            if (AnStock.GPU != "GPU Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockAvaliableFound()
        {
            //create an instance of the class we want co create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method 
            Found = Anstock.Find(StockNo);
            //check the property
            if (Anstock.StockAvaliable != 111)
            {
                OK = false;
            }
            //test to see that the reuslt is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StorageTypeFound()
        {
            //create an instance of the class we want co create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method 
            Found = Anstock.Find(StockNo);
            //check the property
            if (Anstock.StorageType != 123)
            {
                OK = false;
            }
            //test to see that the reuslt is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instacne of hte class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error mesSGE
            string Error = "";
            //invoke the method 
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PCNameinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke hte method 
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            //test to see that the result is corect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PCNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PCName = "aaaaaaa";
            //invoke hte method 
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            //test to see that the result is corect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PCNameMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PCName = "Dell";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PCNameMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PCName = "Dell";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PCNameMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PCName = "aaaa";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PCNameMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PCName = "aaaaaa";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PCNameMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PCName = "aaa";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PCNameExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";

            string PCName = "aaa";
            PCName = PCName.PadRight(500, 'a');
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BuildDateExtremeMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void BuildDateMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string BuildDate = TestDate.ToString();
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void BuildDateMin()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string BuildDate = TestDate.ToString();
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void BuildDateMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string BuildDate = TestDate.ToString();
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void BuildDateExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string BuildDate = TestDate.ToString();
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BuilDateInavalidData()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StorageTypeLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StorageType = "1";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StorageTypeMin()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StorageType = "1";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StorageTypeMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StorageType = "1";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StorageTypeMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StorageType = "1";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StorageTypeMax()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StorageType = "1";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StorageTypeMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StorageType = "1";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StorageTypeMid()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StorageType = "1";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StockAvaliableLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Street = "";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockAvaliableMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Street = "1";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvaliablePlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Street = "";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StockAvaliableMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockAvaliable = "1234343243214123";
            StockAvaliable = StockAvaliable.PadRight(50, 'a');
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvaliableMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockAvailable = "12343432432141234";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StockAvaliableMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockAvailable = "1235432";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RAMLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string RAM = "24";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RANMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string RAM = "20";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void RANMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string RAM = "20";
            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RANMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string RAM = "20";

            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void RAMMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string RAM = "12323232323232323232323232323";

            Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
            Assert.AreNotEqual(Error, "");
        }
       
    }

}


    

      




