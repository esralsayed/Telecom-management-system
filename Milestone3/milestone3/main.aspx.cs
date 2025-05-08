using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3esra
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCustomerLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginMENNA.aspx");
        }

        protected void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginALAA.aspx");
        }
    }
}