using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();

        }

    }

    void DisplayStock()
    {

        PartClasses.clsStockCollection Stock = new PartClasses.clsStockCollection();

        lstStock.DataSource = Stock.StockList;



        lstStock.DataValueField = "StockNo";



        lstStock.DataTextField = "StorageType";


        lstStock.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PCIDNo"] = -1;
        Response.Redirect("AnStock.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 PCIDNo;
        if (lstStock.SelectedIndex != -1)
        {
            PCIDNo = Convert.ToInt32(lstStock.SelectedValue);
            Session["PCIDNo"] = PCIDNo;
            Response.Redirect("Delete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 PCIDNo;

        if (lstStock.SelectedIndex != -1)
        {
            PCIDNo = Convert.ToInt32(lstStock.SelectedIndex);
            Session["PCIDNo"] = PCIDNo;
            Response.Redirect("AnStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }

}

