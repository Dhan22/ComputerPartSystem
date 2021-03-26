using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {

            DisplayStaff();
        }

    }

    void DisplayStaff()
    {
        PartClasses.clsStaffCollection Staff = new PartClasses.clsStaffCollection();

        lstStaff.DataSource = Staff.StaffList;

        lstStaff.DataValueField = "StaffIDNo";

        lstStaff.DataTextField = "StaffName";

        lstStaff.DataBind();




        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Session["StaffIDNo"] = -1;

        Response.Redirect("AnStaff.aspx");



    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        Int32 StaffIDNo;


        if (lstStaff.SelectedIndex != -1)
        {
            StaffIDNo = Convert.ToInt32(lstStaff.SelectedValue);

            Session["StaffIDNo"] = StaffIDNo;

            Response.Redirect("Delete.aspx");


        }
        else
        {
            lblError.Text = "please select a reocrd to delete fromt he list";
        }




    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        Int32 StaffIDNo;

        if (lstStaff.SelectedIndex != -1)
        {
            StaffIDNo = Convert.ToInt32(lstStaff.SelectedValue);

            Session["StaffIDNo"] = StaffIDNo;

            Response.Redirect("AnStaff.aspx");


        }
        else
        {
            lblError.Text = "Please select a record to delete from";
        }




    }
}