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
    public partial class loginMENNA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string mobileNo = mobile.Text.Trim();
                    string password = pass.Text.Trim();

                    
                    string mobvalid = "SELECT COUNT(1) FROM customer_account WHERE mobileNo = @mobile_num";
                    SqlCommand mcmd = new SqlCommand(mobvalid, conn);
                    mcmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    int mobileExists = (int)mcmd.ExecuteScalar();

                    if (mobileExists == 0)
                    {
                        responseL.Text = "Mobile number not found. Please try another number.";
                        return;
                    }

                    
                    string passvalid = "SELECT COUNT(1) FROM customer_account WHERE pass = @pass";
                    SqlCommand pcmd = new SqlCommand(passvalid, conn);
                    pcmd.Parameters.AddWithValue("@pass", password);
                    int passexists = (int)pcmd.ExecuteScalar();

                    if (passexists == 0)
                    {
                        responseL.Text = "Incorrect password.";
                        return;
                    }
                    string query = "select dbo.AccountLoginValidation(@mobile_num, @pass)";
                    SqlCommand AccountLoginValidation = new SqlCommand(query, conn);
                    AccountLoginValidation.Parameters.AddWithValue("@mobile_num", mobileNo);
                    AccountLoginValidation.Parameters.AddWithValue("@pass", password);
                    bool result = (bool)AccountLoginValidation.ExecuteScalar();

                    if (result)
                    {
                        
                        string query2 = "SELECT first_name FROM customer_profile cp INNER JOIN customer_account ca " +
                                        "ON cp.nationalID = ca.nationalID AND ca.mobileNo = @mobileNo AND ca.pass = @password";
                        using (SqlCommand cmd = new SqlCommand(query2, conn))
                        {
                            cmd.Parameters.AddWithValue("@mobileNo", mobileNo);
                            cmd.Parameters.AddWithValue("@password", password);

                            object result2 = cmd.ExecuteScalar();
                            if (result2 != null)
                            {
                                string firstName = result2.ToString();
                                Session["CustomerName"] = firstName;  
                                Response.Redirect("options.aspx");  
                                
                            }
                        }
                    }
                    else
                    {
                        //Response.Write("Error, try again");
                        responseL.Text = "Error, try again!";
                    }
                }
                catch (Exception ex)
                {
                    responseL.Text = $"Error: {ex.Message}";
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginALAA.aspx");
        }
    }
}