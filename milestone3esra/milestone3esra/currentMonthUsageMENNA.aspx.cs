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
    public partial class currentMonthUsageMENNA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewCurr_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
                try
                {
                    string mobileNo = mobileNumber.Text.Trim();
                    string query = "SELECT * from dbo.[Usage_Plan_CurrentMonth](@mobile_num)";
                    SqlCommand currMonth = new SqlCommand(query, conn);
                    currMonth.Parameters.AddWithValue("@mobile_num", mobileNo);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(currMonth);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    currMonthGrid.DataSource = dataTable;
                    currMonthGrid.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write($"Error: {ex.Message}");
                }

        }
    }
}