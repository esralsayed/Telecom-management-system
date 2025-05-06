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
    public partial class CashbackCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            if (!IsPostBack)
            {
                LoadCashbackData();
            }
        }

        private void LoadCashbackData()
        {
            // Connection string from Web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            // Query to fetch data from the Num_of_cashback view
            string query = "SELECT * FROM Num_of_cashback";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Use SqlDataAdapter to fetch data into a DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the GridView
                    GridViewCashback.DataSource = dataTable;
                    GridViewCashback.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle exceptions gracefully
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");

                }
            }
        }
    }
}