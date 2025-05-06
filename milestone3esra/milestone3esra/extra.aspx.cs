using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3esra
{
    public partial class extra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)


        {
            responseL.Text = string.Empty;
            responseR.Text = string.Empty;
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string mobileNo = mobile.Text.Trim();
                    string planName = plan.Text.Trim();
                    string mobvalid = "SELECT COUNT(1) FROM payment WHERE mobileNo = @mobile_num";
                    SqlCommand mcmd = new SqlCommand(mobvalid, conn);
                    mcmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    int mobileExists = (int)mcmd.ExecuteScalar();

                    if (mobileExists == 0)
                    {
                        responseL.Text = "Mobile number not found. Please try another number."; 
                        return;
                    }

                    string pvalid = "SELECT COUNT(1) FROM Service_plan WHERE name = @plan_name";
                    SqlCommand pcmd = new SqlCommand(pvalid, conn);
                    pcmd.Parameters.AddWithValue("@plan_name", planName);
                    int planExists = (int)pcmd.ExecuteScalar();

                    if (planExists == 0)
                    {
                        responseL.Text = "Plan name not found. Please try another plan.";
                        return;
                    }
                    string query = "SELECT dbo.[Extra_plan_amount](@mobile_num, @plan_name)";
                    SqlCommand extra = new SqlCommand(query, conn);
                    extra.Parameters.AddWithValue("@mobile_num", mobileNo);
                    extra.Parameters.AddWithValue("@plan_name", planName);
                    object output = extra.ExecuteScalar();
                    if (output != null && int.TryParse(output.ToString(), out int extra1))
                    {
                        responseR.Text = $"Your extra amount is:{extra1}";
                    }
                    else
                    {
                        responseR.Text = "extra Amount = 0";
                    }


                }
                catch (Exception ex)
                {
                    responseL.Text = $"Error: {ex.Message}";
                }

            }
        }
    }
}