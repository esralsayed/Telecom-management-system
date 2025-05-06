using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.CodeDom;

namespace milestone3esra
{
    public partial class recharge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void a_Click(object sender, EventArgs e)
        {
            ResponseL.Text = string.Empty;
            ResponseR.Text = string.Empty;
            string initiate = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(initiate))
                try
                {
                    conn.Open();
                    string mobileNo = mobile.Text.Trim();
                    string methodp = method.Text.Trim();
                    string paamount = am.Text.Trim();
                    SqlCommand initiate_proc = new SqlCommand("[Initiate_balance_payment]", conn);

                    if (!int.TryParse(mobileNo, out int plan) || !decimal.TryParse(paamount, out decimal amount))
                    {
                        ResponseL.Text = "Numbers only allowed";
                        return;
                    }

                    string mobvalid = "SELECT COUNT(1) FROM customer_account WHERE  mobileNo=@mobile_num";
                    SqlCommand mcmd = new SqlCommand(mobvalid, conn);
                    mcmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    int mobileE = (int)mcmd.ExecuteScalar();
                    if (mobileE == 0)
                    {
                        ResponseL.Text = "Enter another phone number";
                        return;
                    }


                    if (methodp != "cash" && methodp != "credit")
                    {
                        ResponseL.Text = "Enter a valid method , cash or credit ONLY";
                        return;
                    }

                    initiate_proc.CommandType = CommandType.StoredProcedure;
                    initiate_proc.Parameters.Add(new SqlParameter("@payment_method", methodp));
                    initiate_proc.Parameters.Add(new SqlParameter("@mobile_num", mobileNo));
                    initiate_proc.Parameters.Add(new SqlParameter("amount", paamount));



                    object result = initiate_proc.ExecuteNonQuery();
                    if (result != DBNull.Value)
                    {

                        ResponseR.Text = "balance recharged successfully";
                    }
                    else
                    {
                        ResponseR.Text = $"Error no cashback";

                    }
                }

                catch (Exception ex)
                {
                    ResponseL.Text = $"Error : {ex.Message}";
                }

        }
    }
}