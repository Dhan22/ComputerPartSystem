using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartClasses
{

    public class clsStock
    {

        //private data member for active
        private int mPCIDNo;
        //public property for active
        public int PCIDNo
        {
            get

            {
                //return the private data

                return mPCIDNo;
            }
            set
            {
                //set the private data
                mPCIDNo = value;
            }

        }

        //private date added
        private DateTime mBuildDate;
        //public property for build date added
        public DateTime Builddate
        {
            get
            {
                //return the private data

                return mBuildDate;
            }

            set

            {
                //set the private data
                mBuildDate = value;
            }

        }

        //private data member for the Stock No property 
        private Int32 mStockNo;
        //public property for the stock number
        public int StockNo
        {
            get

            {
                //return the private data
                return mStockNo;

            }

            set
            {

                //set the value of the private data member 
                mStockNo = value;
            }

        }

        //private data for PCName
        private string mPCName;
        //public property for PCName
        public string PCName
        {
            get
            {
                //return the private data
                return mPCName;
            }

            set

            {
                //set the ptivate data
                mPCName = value;
            }

        }


        //private data member RAM
        private int mRAM;
        //public property for RAM
        public int RAM
        {
            get
            {
                //return private data'
                return mRAM;

            }

            set
            {

                //set the private data
                mRAM = value;

            }

        }


        //private data member for post code
        private string mCPU;
        //public property for post code
        public string CPU
        {
            get
            {
                //return the private data
                return mCPU;
            }
            set
            {
                //set the private data
                mCPU = value;
            }
        }

        //private data member for street
        private string mGPU;
        //public data member for street
        public string GPU
        {
            get
            {
                //return the private data
                return mGPU;
            }
            set
            {
                //set the private data
                mGPU = value;
            }
        }

        //private data member for town
        private int mStockAvaliable;
        //public data member for Town
        public int StockAvaliable
        {
            get
            {
                //return the private data
                return mStockAvaliable;
            }
            set
            {
                //set the private data
                mStockAvaliable = value;


            }

        }
        //private data member for street
        private int mStorageType;
        //public data member for street
        public int StorageType
        {
            get
            {
                //return the private data
                return mStockAvaliable;
            }
            set
            {
                //set the private data
                mStockAvaliable = value;
            }
        }



        public bool Find(int PCIDNo)
        {

            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramter for the stock no to search for
            DB.AddParameter("@PCIDNo", PCIDNo);
            //execute the stored procedure 
            DB.Execute("sproc_Stock_FilterByPCIDNo");
            //if one recorf is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to hte prviate data members
                mPCIDNo = Convert.ToInt32(DB.DataTable.Rows[0]["PCIDNo"]);
                mPCName = Convert.ToString(DB.DataTable.Rows[0]["PCName"]);
                mRAM = Convert.ToInt32(DB.DataTable.Rows[0]["RAM"]);
                mCPU = Convert.ToString(DB.DataTable.Rows[0]["CPU"]);
                mGPU = Convert.ToString(DB.DataTable.Rows[0]["GPU"]);
                mBuildDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BuildDate"]);
                mStockAvaliable = Convert.ToInt32(DB.DataTable.Rows[0]["StockAvaliable"]);
                mStorageType = Convert.ToInt32(DB.DataTable.Rows[0]["StorageType"]);

                return true;
            }
            //if no record was found
            else
            {
                return false;
            }

        }


        public string Valid(string pCName, string rAM, string gPU, string stockAvaliable, string StorageType)
        {

            DateTime DateTemp;

            String Error = "";


            if (PCName.Length == 0)
            {
                Error = Error + "The PCID no may be blank ; ";
            }
            if (PCName.Length > 6)
            {
                Error = Error + "The PCName must be less than 6 charaacters ; ";
            }
            DateTemp = Convert.ToDateTime(Builddate);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";

            }
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }

            if (PCName.Length == 0)
            {
                Error = Error + "The PC Name may be blank : ";
            }

            if (PCName.Length > 9)
            {
                Error = Error + "The PC Name must be less than 9 characters : ";
            }


            if (StorageType.Length == 0)
            {
                Error = Error + "The StorageType must be less than 50 characters : ";
            }
            if (GPU.Length == 0)
            {
                Error = Error + "The RAN may not be blank :";
            }
            if (CPU.Length > 50)
            {
                Error = Error + "The CPU must be less than 50 characters :";
            }

            try
            {
                DateTemp = Convert.ToDateTime(Builddate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the futre : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
                //return any error messages


            }
            return Error;

        }

   

        }

    }

































