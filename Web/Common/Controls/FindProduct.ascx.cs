using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Web_Common_Controls_FindProduct : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadFindFlag.SelectedValue == "0")
        {
            Session["name"] = TxtFindText.Text;
            Session["Producer"] = "";
        }
        else
        {
            Session["name"] = "";
            Session["Producer"] = TxtFindText.Text;
        }
        Response.Redirect("~/Web/User/ProductFind.aspx");
    }
}
