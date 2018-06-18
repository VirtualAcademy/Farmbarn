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

public partial class Web_Common_Controls_UserLogin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            BsUser user = (BsUser)Session["user"];
            Label1.Text = "Welcome the visit of " + user.Realname ;
            MultiView1.ActiveViewIndex = 1;
        }
        else
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {

        if (TxtUserName.Text == "cho" && TxtUserPwd.Text == "1234")
        {
            BsUser user = new BsUser();
            user.Realname = "cho";
            Session["user"] = user;
            Response.Redirect("Default.aspx");
        }
    }
    protected void LogoutButton_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}
