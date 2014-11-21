using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TrangAdmin_Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Literal1.Text = "Xin chào: " + Session["Username"].ToString();
    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Session["Username"] = null;
        Response.Redirect("~/Trangchu.aspx");
    }
}
