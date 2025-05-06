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
    public partial class pastPlans5months : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void unsubView_Click(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
                try
                {
                    conn.Open();

                    string mobileNo = mobileNumber.Text.Trim();
                    string mobvalid = "SELECT COUNT(1) FROM customer_account WHERE  mobileNo=@mobile_num";
                    SqlCommand mcmd = new SqlCommand(mobvalid, conn);
                    mcmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    int mobileE = (int)mcmd.ExecuteScalar();
                    if (mobileE == 0)
                    {
                        Response.Write("Enter another phone number");
                        return;
                    }


                    string query = "SELECT * from dbo.[Subscribed_plans_5_Months] (@mobile_num)";
                    SqlCommand sub = new SqlCommand(query, conn);

                    sub.Parameters.AddWithValue("@mobile_num", mobileNo);


                    SqlDataAdapter adapter = new SqlDataAdapter(sub);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    subscribe.DataSource = dataTable;
                    subscribe.DataBind();

                
                }

                catch (Exception ex)
                {
                    Response.Write($"Error : {ex.Message}");
                }

        }
    }
}

    
