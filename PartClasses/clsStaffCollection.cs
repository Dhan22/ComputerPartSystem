using System.Collections.Generic;
using System;

namespace PartClasses
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        List<clsStaff> mCount = new List<clsStaff>();

        clsStaff mThisStaff = new clsStaff();

        



        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }



        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

      

        public clsStaffCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();

                AnStaff.StaffIDNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffIDNo"]);
                AnStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                

                mStaffList.Add(AnStaff);

                Index++;


            }




        }

       
        public void Delete()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("StaffIDNo", mThisStaff.StaffIDNo);

            DB.Execute("sproc_tblStaff_Delete");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("StaffName", mThisStaff.StaffName);
            DB.AddParameter("StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("StaffTelNo", mThisStaff.StaffTelNo);
            DB.AddParameter("StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("AddressID", mThisStaff.AddressID);

            DB.Execute("sproc_tblStaff_Update");


        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("StaffName", mThisStaff.StaffName);
            DB.AddParameter("StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("StaffTelNo", mThisStaff.StaffTelNo);
            DB.AddParameter("StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("AddressID", mThisStaff.AddressID);


            return DB.Execute("sproc_tblStaff_Insert");




        }



























    }
        
}