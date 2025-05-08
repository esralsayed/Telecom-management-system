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
    public partial class Payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();




            // SqlConnection conn = new SqlConnection(connStr);





            if (!IsPostBack)
            {
                LoadPaymentsData();
            }
        }

        private void LoadPaymentsData()
        {
            // Connection string from Web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            // SQL query to fetch data from the AccountPayments view
            string query = "SELECT * FROM AccountPayments";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Use SqlDataAdapter to fetch data into a DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the GridView
                    GridViewPayments.DataSource = dataTable;
                    GridViewPayments.DataBind();
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