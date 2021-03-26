using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PartClasses;

public partial class Delete : System.Web.UI.Page
{
    Int32 StaffIDNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffIDNo = Convert.ToInt32(Session["StaffIDNo"]);
    }

    void DeleteStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();


        StaffBook.ThisStaff.Find(StaffIDNo);


        StaffBook.Delete();



    }




    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteStaff();

        Response.Redirect("Default.aspx");
    }
}