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
    public partial class NotResolved : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void enterNAID_Click(object sender, EventArgs e)
        {
            responseL.Text = string.Empty;
            responseR.Text = string.Empty;
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
                try
                {
                    conn.Open();
                    SqlCommand tickets = new SqlCommand("[Ticket_Account_Customer]", conn);
                    tickets.CommandType = CommandType.StoredProcedure;
                    int.TryParse(naID.Text, out int nationalID);
                    string idvalid = "SELECT COUNT(1) FROM customer_profile WHERE nationalID = @NID";
                    SqlCommand mcmd = new SqlCommand(idvalid, conn);
                    mcmd.Parameters.AddWithValue("@NID", nationalID);
                    int naexists = (int)mcmd.ExecuteScalar();

                    if (naexists == 0)
                    {
                        responseL.Text = "Please try another National ID.";
                        return;
                    }
                    tickets.Parameters.Add(new SqlParameter("@NID", nationalID));
                    
                    //tickets.ExecuteNonQuery();
                    object result = tickets.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ticketCount))
                    {
                        responseR.Text = $"Tickets: {ticketCount}";
                    }
                    else
                    {
                        responseR.Text = "No tickets found";
                    }
                }
                catch (Exception ex)
                {
                    responseL.Text = $"Error: {ex.Message}";
                }

        }
    }
}