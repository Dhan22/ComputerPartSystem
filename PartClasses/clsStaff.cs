using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartClasses


{

    public class clsStaff
    {
        

        private int mStaffIDNo;
        public Int32 StaffIDNo
        {
            get
            {
                return mStaffIDNo; 
            }

            set
            {
                mStaffIDNo = value;
            }

         }

        private string mStaffEmail;
        //public property for house no
        public string StaffEmail 
        {
            get 
            {
                //return private data
                return mStaffEmail;
            }
            set 
            {
                //set the private data
                mStaffEmail = value;
            }
        }
        private string mStaffName;
        //public property for house no
        public string StaffName
        {
            get
            {
                //return private data
                return mStaffName;
            }
            set
            {
                //set the private data
                mStaffName = value;
            }
        }
        private int mStaffTelNo;
        public Int32 StaffTelNo
        {
            get
            {
                return mStaffTelNo;
            }

            set
            {
                mStaffTelNo = value;
            }

        }
        private DateTime mStaffDOB;
        //public property for date added
        public DateTime StaffDOB
        {
            get
            {
                //return the private data
                return mStaffDOB;
            }
            set
            {
                //set the private data
                mStaffDOB = value;
            }
        }
        private int mAddressID;
        public Int32 AddressID
        {
            get
            {
                return mAddressID;
            }

            set
            {
                mAddressID = value;
            }

        }

        public bool Find(int StaffIDNo)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffIDNo", StaffIDNo);

            DB.Execute("sproc_tblStaff_FilterByStaffIDNo");

            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mStaffIDNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffIDNo"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
               

                //always return true
                return true;
            }

            else
            {
                return false;
            }


        }

        



        public string Valid(string StaffName, string StaffEmail, string StaffDOB, string StaffTelNo, string AddressID)
        {
            String Error = "";

            DateTime DateTemp;

            if (StaffName.Length == 0)
            {
                Error = Error + "The Staff Name must not be blank : ";
            }

            if (StaffName.Length > 50)
            {
                Error = Error + "The Staff Name must not be more than 50 characters : ";

            }

            if (StaffEmail.Length == 0)
            {
                Error = Error + "The Staff email must not be blank : ";
            }

            if (StaffEmail.Length > 50)
            {
                Error = Error + "The Staff email must not be more than 50 characters : ";

            }


            if (StaffTelNo.Length == 0)
            {
                Error = Error + "The Staff tell phone number must not be blank : ";
            }

            if (StaffTelNo.Length > 50)
            {
                Error = Error + "The Staff tell phone number must not be more than 50 characters : ";

            }

           


            try
            {
                DateTemp = Convert.ToDateTime(StaffDOB);

                if (DateTemp < DateTime.Now.Date)

                {
                    Error = Error + "The date is invalid : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date can not be in the future :";
                }

            }

            catch
            {
                Error = Error + "The date is invalid : ";
            }




            return Error;
        }

       
       
                  


    }
}         