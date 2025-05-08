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
    public partial class cashbackbenefit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
                try
                {
                    conn.Open();
                    string mobileNo = mobno.Text.Trim();
                    string pid = payment.Text.Trim();
                    string bid = benefit.Text.Trim();
                    SqlCommand cash = new SqlCommand("[Payment_wallet_cashback]", conn);
                    cash.Parameters.Add(new SqlParameter("@mobile_num", mobileNo));
                    cash.Parameters.Add(new SqlParameter("@payment_id", pid));
                    cash.Parameters.Add(new SqlParameter("@benefit_id", bid));
                    cash.CommandType = CommandType.StoredProcedure;


                    object result = cash.ExecuteNonQuery();
                    if (result != DBNull.Value)
                    {

                        Response.Write($"the amount of cashback is {result}");
                    }
                    else
                    {
                        Response.Write($"Error no cashback");

                    }
                }

                catch (Exception ex)
                {
                    Response.Write($"Error : {ex.Message}");
                }

        }
    }
}