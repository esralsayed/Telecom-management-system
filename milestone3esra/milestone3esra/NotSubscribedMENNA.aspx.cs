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
    public partial class NotSubscribedMENNA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void unsubView_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
                try
                {
                    string mobileNo = mobileNumber.Text.Trim();
                    string query = "exec [Unsubscribed_Plans] @mobile_num";
                    SqlCommand notSub = new SqlCommand(query, conn);
                    // notSub.CommandType = CommandType.StoredProcedure;
                    notSub.Parameters.AddWithValue("@mobile_num", mobileNo);
                    conn.Open();
                    // notSub.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(notSub);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    nonSubGrid.DataSource = dataTable;
                    nonSubGrid.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write($"Error: {ex.Message}");
                }
        }
    }
}