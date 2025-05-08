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
    public partial class RemoveBenefits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RemoveBenefitsButton_Click(object sender, EventArgs e)
        {
            string mobileNumber = mobileNoTextBox.Text.Trim();
            string planIdInput = planIdTextBox.Text.Trim();

            // Validate inputs
            if (mobileNumber.Length == 11 && int.TryParse(planIdInput, out int planId))
            {
                string connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                try
                {
                    SqlCommand cmd = new SqlCommand("Benefits_Account", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@mobile_num", mobileNumber));
                    cmd.Parameters.Add(new SqlParameter("@plan_id", planId));

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('Benefits successfully removed for the specified account and plan.');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('No matching benefits found for the specified account and plan.');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid input. Please enter a valid mobile number and plan ID.');</script>");

            }
        }
    }
}