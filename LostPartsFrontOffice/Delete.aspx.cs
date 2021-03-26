using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    Int32 PCIDNo;


    protected void Page_Load(object sender, EventArgs e)
    {
        PCIDNo = Convert.ToInt32(Session["PCIDNo"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeletePCIDNo();
        Response.Redirect("AnStock.aspx");
    }

    private void DeletePCIDNo()
    {
        throw new NotImplementedException();
    }
}