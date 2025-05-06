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
    public partial class highestVoucher : System.Web.UI.Page
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
                try
                {
                    conn.Open();
                    String mobileNo = mobile.Text;
                    string mobvalid = "SELECT COUNT(1) FROM voucher WHERE mobileNo = @mobile_num";
                    SqlCommand mcmd = new SqlCommand(mobvalid, conn);
                    mcmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    int mobileExists = (int)mcmd.ExecuteScalar();

                    if (mobileExists == 0)
                    {
                        responseL.Text = "Mobile number not found. Please try another number.";
                        return;
                    }
                    
                        SqlCommand voucher = new SqlCommand("[Account_Highest_Voucher]", conn);
                        voucher.CommandType = CommandType.StoredProcedure;
                        voucher.Parameters.Add(new SqlParameter("@mobile_num", mobileNo));

                        SqlDataReader reader = voucher.ExecuteReader();
                        if (reader.Read())
                        {
                            int voucherID = reader.GetInt32(0);
                            responseR.Text = $"The highest voucher ID is: Voucher Number {voucherID}";
                        }
                        else
                        {
                            responseR.Text = "Couldn't find a voucher";
                        }
                        reader.Close();

                    
                }
                catch (Exception ex)
                {
                    responseL.Text = $"Error: {ex.Message}";
                }
        }
    }
}