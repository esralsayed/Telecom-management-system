using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3esra
{
    public partial class loginALAA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string adminIDAc = "22615";
            string adminPassword = "123";

            string id = adminID.Text.Trim();
            string pass = adminPass.Text.Trim();

            if (id == adminIDAc && pass == adminPassword)
            {

                Response.Redirect("admin.aspx");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginMENNA.aspx");
        }
    }
}