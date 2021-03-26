using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PartClasses;
public partial class AnStock : System.Web.UI.Page
{
    Int32 PCIDNo;

    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (PCIDNo == -1)
        {
            Add();
        }
        else
        {
            Update();
        }


        Add();
        Response.Redirect("AnStock.aspx");
        //create a new instacne of clsStock
        clsStock AnStock = new clsStock();
        //capture the stock no
        string PCName = txtPCName.Text;
        string RAM = txtRAM.Text;
        string CPU = txtCPU.Text;
        string GPU = txtGPU.Text;
        string BuildDate = txtBuildDate.Text;
        string StockAvaliable = txtStockAvailable.Text;
        string StorageType = txtStorageType.Text;
        string Error = "";
        Error = AnStock.Valid(PCName, RAM, GPU, StockAvaliable, StorageType);
        if (Error == "")
        {
            AnStock.PCName = PCName;
            AnStock.RAM = Convert.ToInt32(RAM);
            AnStock.CPU = CPU;
            AnStock.GPU = GPU;
            AnStock.Builddate = Convert.ToDateTime(txtBuildDate);
            AnStock.StockAvaliable = Convert.ToInt32(txtStockAvailable);
            AnStock.StorageType = Convert.ToInt32(txtStorageType);
            Session["AnStock"] = AnStock;
            Response.Write("AnStockViewer.aspx");
        }
        else
        {
            lblStorageType.Text = Error;


        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 PCIDNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get hte primary key entered by the user
        PCIDNo = Convert.ToInt32(txtPCIDNo.Text);
        //find hte record 
        Found = AnStock.Find(PCIDNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties
            txtBuildDate.Text = AnStock.Builddate.ToString();
            txtCPU.Text = AnStock.CPU;
            txtGPU.Text = AnStock.GPU;
            txtPCName.Text = AnStock.PCName;
            txtRAM.Text = AnStock.RAM.ToString();
            txtStockAvailable.Text = AnStock.StockAvaliable.ToString();
            txtStorageType.Text = AnStock.StorageType.ToString();

        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        PCIDNo = Convert.ToInt32(Session["PCIDNo"]);

    }
    

    protected void txtPCIDNo_TextChanged(object sender, EventArgs e)
    {

    }

    void Add()
    {
        PartClasses.clsStockCollection StockBook = new PartClasses.clsStockCollection();
        String Error = StockBook.ThisStock.Valid(txtPCName.Text, txtGPU.Text, txtRAM.Text, txtStockAvailable.Text, txtStorageType.Text);
        if (Error == "")
        {
            StockBook.ThisStock.PCName = txtPCName.Text;
            StockBook.ThisStock.GPU = txtGPU.Text;
            StockBook.ThisStock.RAM = Convert.ToInt32(txtRAM.Text);
            StockBook.ThisStock.StockAvaliable = Convert.ToInt32(txtStockAvailable.Text);
            StockBook.ThisStock.StorageType = Convert.ToInt32(txtStorageType.Text);
            StockBook.Add();
            Response.Redirect("AnStock.aspx");
        }

        else
        {
            lblError.Text = "There were prblems with the data entered" + Error;
        }



    }

    void Update()
    {
        PartClasses.clsStockCollection StockBook = new PartClasses.clsStockCollection();
        String Error = StockBook.ThisStock.Valid(txtPCName.Text, txtRAM.Text, txtGPU.Text, txtStockAvailable.Text, txtStorageType.Text);
        if (Error == "")
        {
            StockBook.ThisStock.Find(PCIDNo);
            StockBook.ThisStock.PCName = txtPCName.Text;
            StockBook.ThisStock.RAM = Convert.ToInt32(txtRAM.Text);
            StockBook.ThisStock.CPU = txtCPU.Text;
            StockBook.ThisStock.GPU = txtGPU.Text;
            StockBook.ThisStock.Builddate = Convert.ToDateTime(txtBuildDate.Text);
            StockBook.ThisStock.StockAvaliable = Convert.ToInt32(txtStockAvailable.Text);
            StockBook.ThisStock.StorageType = Convert.ToInt32(txtStorageType.Text);
            StockBook.Update();
            Response.Redirect("AnStock");
        }

        else
        {
            lblError.Text = "There were problems with the data entered" + Error;

        }

        }

    }


      

        










