using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PartClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();

        AnStaff = (clsStaff)Session["AnStaff"];

        Response.Write(AnStaff.StaffIDNo);

        Response.Write(AnStaff.StaffName);

        Response.Write(AnStaff.StaffEmail);

        Response.Write(AnStaff.StaffDOB);

        Response.Write(AnStaff.StaffTelNo);

        Response.Write(AnStaff.AddressID);


    }
}