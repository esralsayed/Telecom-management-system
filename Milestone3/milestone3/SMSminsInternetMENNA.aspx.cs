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
    public partial class SMSminsInternetMENNA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewSMSminInt_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
                try
                {
                    conn.Open();
                    string PlanName = planName.Text;
                    string StartDate = startDate.Text;
                    string EndDate = endDate.Text;

                    SqlCommand Consumption = new SqlCommand("SELECT * from dbo.[Consumption](@Plan_name , @start_date , @end_date)", conn);
                    // Consumption.CommandType = CommandType.StoredProcedure/;
                    Consumption.Parameters.AddWithValue("@Plan_name", PlanName);
                    Consumption.Parameters.AddWithValue("@start_date", StartDate);
                    Consumption.Parameters.AddWithValue("@end_date", EndDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(Consumption);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    planUsageTable.DataSource = dataTable;
                    planUsageTable.DataBind();
                }

                catch (Exception ex)
                {
                    Response.Write($"Error: {ex.Message}");
                }

        }
    }
}