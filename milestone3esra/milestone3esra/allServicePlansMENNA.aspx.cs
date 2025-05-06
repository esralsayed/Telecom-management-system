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
    public partial class allServicePlansMENNA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
                try
                {
                    SqlCommand allServicePlans = new SqlCommand("select * from allServicePlans", conn);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(allServicePlans);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    serviceGrid.DataSource = dataTable;
                    serviceGrid.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write($"Error: {ex.Message}");
                }
        }

       
    }
}