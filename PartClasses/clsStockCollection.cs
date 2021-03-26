using System.Collections.Generic;
using System;



namespace PartClasses
{
    public class clsStockCollection

    {
        Int32 PCIDNo;


        List<clsStock> mStockList = new List<clsStock>();
        clsStock mthisStock = new clsStock();

        public clsStockCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_Stock_SelectAll");

            RecordCount = DB.Count;


            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.PCIDNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PCIDNo"]);
                AnStock.PCName = Convert.ToString(DB.DataTable.Rows[Index]["PCName"]);
                AnStock.RAM = Convert.ToInt32(DB.DataTable.Rows[Index]["RAM"]);
                AnStock.CPU = Convert.ToString(DB.DataTable.Rows[Index]["CPU"]);
                AnStock.GPU = Convert.ToString(DB.DataTable.Rows[Index]["GPU"]);
                AnStock.Builddate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BuildDate"]);
                AnStock.StockAvaliable = Convert.ToInt32(DB.DataTable.Rows[Index]["StockAvaliable"]);
                AnStock.StorageType = Convert.ToInt32(DB.DataTable.Rows[Index]["StorageType"]);
                mStockList.Add(AnStock);
                Index++;

            }
        }

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }

        }

        public int Count
        {
            get
            {
                return mStockList.Count;

            }
            set
            {

            }
        }

        public clsStock ThisStock
        {
            get
            {
                return mthisStock;
            }
            set
            {
                mthisStock = value;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PCName", mthisStock.PCName);
            DB.AddParameter("@RAM", mthisStock.RAM);
            DB.AddParameter("@CPU", mthisStock.CPU);
            DB.AddParameter("@GPU", mthisStock.GPU);
            DB.AddParameter("@BuildDate", mthisStock.Builddate);
            DB.AddParameter("@StockAvaliable", mthisStock.StockAvaliable);
            DB.AddParameter("@StorageType", mthisStock.StorageType);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PCIDNo", mthisStock.PCIDNo);
            DB.Execute("sproc_tblStock_Delete");


        }

        void DeleteStock()
        {
            clsStockCollection StockBook = new clsStockCollection();
            StockBook.ThisStock.Find(PCIDNo);
            StockBook.Delete();



        }


        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PCIDNo", ThisStock.PCIDNo);
            DB.AddParameter("@PCName", ThisStock.PCName);
            DB.AddParameter("@RAM", ThisStock.RAM);
            DB.AddParameter("@CPU", ThisStock.CPU);
            DB.AddParameter("@GPU", ThisStock.GPU);
            DB.AddParameter("@BuildDate", ThisStock.Builddate);
            DB.AddParameter("@StockAvaliable", ThisStock.StockAvaliable);
            DB.AddParameter("@StorageType", ThisStock.StorageType);
            DB.Execute("sproc_tblStock_Update");

        }
    

        void DisplayPCIDNo()
        {
            clsStockCollection StockBook = new clsStockCollection();
            StockBook.ThisStock.Find(PCIDNo);

        }
    }

}






     
        
 