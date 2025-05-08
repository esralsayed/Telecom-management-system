using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3esra
{
    public partial class renewplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            ResponseL.Text = string.Empty;
            ResponseR.Text = string.Empty;
            string renew = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            SqlConnection conn = new SqlConnection(renew);
            try
            {
                conn.Open();
                string mobileNo = mobile.Text.Trim();
                string methodp = method.Text.Trim();
                string paamount = am.Text.Trim();
                string planid = pid.Text.Trim();
                SqlCommand renewalproc = new SqlCommand("[Initiate_plan_payment]", conn);

                renewalproc.CommandType = CommandType.StoredProcedure;
                renewalproc.Parameters.Add(new SqlParameter("@plan_id", planid));
                renewalproc.Parameters.Add(new SqlParameter("@mobile_num", mobileNo));
                renewalproc.Parameters.Add(new SqlParameter("@amount", paamount));
                renewalproc.Parameters.Add(new SqlParameter("@payment_method", methodp));

                if (!int.TryParse(planid, out int plan) ||
                   !decimal.TryParse(paamount, out decimal amount))
                {
                    ResponseL.Text = "Enter numbers ONLY";
                    return;
                }

                if (string.IsNullOrEmpty(mobileNo))
                {
                    ResponseL.Text = "Mobile number cannot be empty.";
                    return;
                }

                object result = renewalproc.ExecuteNonQuery();

                if (result != null)
                {
                    ResponseR.Text = "Renewal was successful!";
                    return;
                }
                else
                {
                    ResponseL.Text = "error during renewal!";
                    return;
                }


            }

            catch (SqlException ex)
            {
                ResponseL.Text = "Error during renewal";
                return;
            }


        }
    }

}
