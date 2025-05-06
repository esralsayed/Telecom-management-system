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
    public partial class WalletDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();




            // SqlConnection conn = new SqlConnection(connStr);





            if (!IsPostBack)
            {
                LoadCustomerWallets();
            }
        }

        private void LoadCustomerWallets()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            string query = "SELECT * FROM CustomerWallet";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open(); // not included 
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                GridViewCustomerWallets.DataSource = dataTable;
                GridViewCustomerWallets.DataBind();

            }
        }
    }
}