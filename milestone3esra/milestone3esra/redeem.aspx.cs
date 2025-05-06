using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace milestone3esra
{
    public partial class redeem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ResponseL.Text = string.Empty;
            ResponseR.Text = string.Empty;
            string redeem = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(redeem))
                try
                {
                    conn.Open();
                    string mobileNo = mobno.Text.Trim();
                    string voucherid = vid.Text.Trim();
                    SqlCommand redeem_voucher = new SqlCommand("[Redeem_voucher_points]", conn);
                    if (!int.TryParse(mobileNo, out int m))
                    {
                        Response.Write("Enter numbers ONLY");
                        return;
                    }

                    string mobvalid = "SELECT COUNT(1) FROM voucher WHERE  mobileNo=@mobile_num";
                    SqlCommand mcmd = new SqlCommand(mobvalid, conn);
                    mcmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    int mobileE = (int)mcmd.ExecuteScalar();
                    if (mobileE == 0)
                    {
                        ResponseL.Text = "Enter another phone number";
                        return;
                    }
                    string vvalid = "SELECT COUNT(1) FROM voucher WHERE  voucherID=@voucher_id";
                    SqlCommand vcmd = new SqlCommand(vvalid, conn);
                    vcmd.Parameters.AddWithValue("@voucher_id", voucherid);
                    int vE = (int)vcmd.ExecuteScalar();
                    if (vE == 0)
                    {
                        ResponseL.Text = "Enter another voucher number";
                        return;
                    }

                    redeem_voucher.CommandType = CommandType.StoredProcedure;
                    redeem_voucher.Parameters.Add(new SqlParameter("@mobile_num", mobileNo));
                    redeem_voucher.Parameters.Add(new SqlParameter("@voucher_id", voucherid));
                    object result = redeem_voucher.ExecuteNonQuery();
                    if (result != null)
                    {
                        ResponseR.Text = "Redeemed successfully!";
                    }
                    else
                    {
                        ResponseR.Text = $"Error couldn't redeem";

                    }

                }
                catch (Exception ex)
                {
                    ResponseL.Text = $"Error : {ex.Message}";
                }
        }
    }
}
