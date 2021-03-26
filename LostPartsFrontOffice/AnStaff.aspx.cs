using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PartClasses;

public partial class AnStaff : System.Web.UI.Page
{
    Int32 StaffIDNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffIDNo = Convert.ToInt32(Session["StaffIDNo"]);
        if (StaffIDNo != -1)
        {
            DisplayStaff();
        }
        
    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (StaffIDNo == -1)
        {
            Add();
        }
        else
        {
            Update();

            
        }
    }




      

    protected void btnFind12_Click(object sender, EventArgs e)   
    {
        


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {

        clsStaff AnStaff = new clsStaff();

        Int32 StaffIDNo;

        Boolean Found = false;

        StaffIDNo = Convert.ToInt32(txtStaffIDNo.Text);

        Found = AnStaff.Find(StaffIDNo);

        if (Found == true)
        {


            txtName.Text = AnStaff.StaffName;

            txtEmail.Text = AnStaff.StaffEmail;

            txtDOB.Text = AnStaff.StaffDOB.ToString();

            txtTelNo.Text = AnStaff.StaffTelNo.ToString();

            txtAddressID.Text = AnStaff.AddressID.ToString();


            

        }
    }
    void Add()
    {
        PartClasses.clsStaffCollection StaffBook = new PartClasses.clsStaffCollection();

        String Error = StaffBook.ThisStaff.Valid(txtName.Text, txtEmail.Text, txtDOB.Text, txtTelNo.Text, txtAddressID.Text);

        if (Error == "")
        {
            StaffBook.ThisStaff.StaffName = txtName.Text;
            StaffBook.ThisStaff.StaffEmail = txtEmail.Text;
            StaffBook.ThisStaff.StaffDOB = Convert.ToDateTime(txtDOB.Text);
            StaffBook.ThisStaff.StaffTelNo = Convert.ToInt32(txtTelNo.Text);
            StaffBook.ThisStaff.AddressID = Convert.ToInt32(txtAddressID.Text);

            StaffBook.Add();

            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }


    }
    void Update()
    {
        PartClasses.clsStaffCollection StaffBook = new PartClasses.clsStaffCollection();

        String Error = StaffBook.ThisStaff.Valid(txtName.Text, txtEmail.Text, txtDOB.Text, txtTelNo.Text, txtAddressID.Text);

        if (Error == "")
        {
            StaffBook.ThisStaff.Find(StaffIDNo);

            StaffBook.ThisStaff.StaffName = txtName.Text;
            StaffBook.ThisStaff.StaffEmail = txtEmail.Text;
            StaffBook.ThisStaff.StaffDOB = Convert.ToDateTime(txtDOB.Text);
            StaffBook.ThisStaff.StaffTelNo = Convert.ToInt32(txtTelNo.Text);
            StaffBook.ThisStaff.AddressID = Convert.ToInt32(txtAddressID.Text);

            StaffBook.Update();

            Response.Redirect("Default.aspx");


        }
        else
        {
            lblError.Text = "There is a problem with the data entered" + Error;
        }

    }

    void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();

        StaffBook.ThisStaff.Find(StaffIDNo);

        txtName.Text = StaffBook.ThisStaff.StaffName;

        txtEmail.Text = StaffBook.ThisStaff.StaffEmail;

        txtDOB.Text = StaffBook.ThisStaff.StaffDOB.ToString();
     
        txtTelNo.Text = StaffBook.ThisStaff.StaffTelNo.ToString();

        txtAddressID.Text = StaffBook.ThisStaff.AddressID.ToString();


    }


}