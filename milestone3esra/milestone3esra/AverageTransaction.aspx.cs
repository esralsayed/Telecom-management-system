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
    public partial class AverageTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnFetchAverage_Click(object sender, EventArgs e)
        {
            // Get input values
            string walletIdText = txtWalletID.Text.Trim();
            string startDateText = txtStartDate.Text.Trim();
            string endDateText = txtEndDate.Text.Trim();

            // Validate inputs
            if (!int.TryParse(walletIdText, out int walletID))
            {
                lblResult.Text = "Please enter a valid numeric Wallet ID.";
                return;
            }

            if (!DateTime.TryParse(startDateText, out DateTime startDate) || !DateTime.TryParse(endDateText, out DateTime endDate))
            {
                lblResult.Text = "Please enter valid dates in YYYY-MM-DD format.";
                return;
            }

            // Fetch the average transaction amount
            FetchAverageTransferAmount(walletID, startDate, endDate);
        }

        private void FetchAverageTransferAmount(int walletID, DateTime startDate, DateTime endDate)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create the SQL command
                    SqlCommand command = new SqlCommand("SELECT dbo.Wallet_Transfer_Amount(@walletID, @start_date, @end_date)", connection);
                    command.CommandType = CommandType.Text;

                    // Add parameters
                    command.Parameters.AddWithValue("@walletID", walletID);
                    command.Parameters.AddWithValue("@start_date", startDate);
                    command.Parameters.AddWithValue("@end_date", endDate);

                    // Open the connection
                    connection.Open();

                    // Execute the command and get the result
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int averageAmount))
                    {
                        lblResult.Text = $"Average Transaction Amount: {averageAmount}";
                    }
                    else
                    {
                        lblResult.Text = "No data found for the given inputs.";
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions gracefully
                    lblResult.Text = $"An error occurred: {ex.Message}";

                }
            }
        }
    }
}