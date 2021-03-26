using System;
using System.Collections.Generic;
using PartClasses;


public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
       clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];
        //dispay the stock number for this entry
        Response.Write(AnStock.StockNo);
        Response.Write(AnStock.Builddate);
        Response.Write(AnStock.GPU);
        Response.Write(AnStock.PCIDNo);
        Response.Write(AnStock.PCName);
        Response.Write(AnStock.RAM);
        Response.Write(AnStock.StockAvaliable);
        Response.Write(AnStock.StorageType);


    }
}