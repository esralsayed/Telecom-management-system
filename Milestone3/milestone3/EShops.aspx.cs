using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3esra
{
    public partial class EShops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  String connStr = WebConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ToString();
            if (!IsPostBack)
            {
                LoadEshopVouchers();
            }
        }

        private void LoadEshopVouchers()
        {
            // Connection string from Web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            // SQL query to fetch data from the view
            string query = "SELECT * FROM E_shopVouchers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Fill DataTable with query results
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the GridView
                    GridViewEshopVouchers.DataSource = dataTable;
                    GridViewEshopVouchers.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log error, show message)
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");

                }
            }
        }
    }
}