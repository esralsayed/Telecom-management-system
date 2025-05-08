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
    public partial class cashbackNatIDMENNA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr)) 
            try
            {
                conn.Open();
                string natID = nationalID.Text.Trim();
                string query = "SELECT * from dbo.[Cashback_Wallet_Customer](@NID)";
                SqlCommand currMonth = new SqlCommand(query, conn);
                currMonth.Parameters.AddWithValue("@NID", natID);
                
                SqlDataAdapter adapter = new SqlDataAdapter(currMonth);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cashbackGrid.DataSource = dataTable;
                cashbackGrid.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write($"Error: {ex.Message}");
            }
        }
    }
}