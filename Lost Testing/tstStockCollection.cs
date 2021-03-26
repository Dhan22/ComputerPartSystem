using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartClasses;
using System.Collections.Generic;

namespace Lost_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void TestMethod1()
        {

        }


        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);

        }



        [TestMethod]
        public void StockListOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.PCName = "1";
            TestItem.RAM = 1;
            TestItem.StorageType = 1;
            TestItem.Builddate = DateTime.Now.Date;
            TestItem.GPU = "Dell";
            TestItem.CPU = "AMD";
            TestItem.StockAvaliable = 1;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            int SomeCount = 2;
            AllStock.Count = SomeCount;
            Assert.AreEqual(AllStock.Count, SomeCount);


        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.PCName = "1";
            TestItem.RAM = 1;
            TestItem.StorageType = 1;
            TestItem.Builddate = DateTime.Now.Date;
            TestItem.GPU = "Dell";
            TestItem.CPU = "AMD";
            TestItem.StockAvaliable = 1;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList.Count);
        }

        [TestMethod]
        public void TwoRecrodsPresent()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.AreEqual(AllStock.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.PCName = "true";
            TestItem.RAM = 1;
            TestItem.CPU = "1";
            TestItem.GPU = "1";
            TestItem.Builddate = DateTime.Now.Date;
            TestItem.StockAvaliable = 1;
            TestItem.StorageType = 2;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.PCIDNo = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.PCName = "true";
            TestItem.RAM = 1;
            TestItem.CPU = "1";
            TestItem.GPU = "1";
            TestItem.Builddate = DateTime.Now.Date;
            TestItem.StockAvaliable = 1;
            TestItem.StorageType = 2;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.PCIDNo = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        }

}