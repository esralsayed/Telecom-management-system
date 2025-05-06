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
    public partial class CashbackReturned : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFetchCashback_Click(object sender, EventArgs e)
        {
            // Get input values
            string walletIdText = txtWalletID.Text.Trim();
            string planIdText = txtPlanID.Text.Trim();

            // Validate inputs
            if (!int.TryParse(walletIdText, out int walletID) || !int.TryParse(planIdText, out int planID))
            {
                lblResult.Text = "Please enter valid numeric values for Wallet ID and Plan ID.";
                return;
            }

            // Fetch the cashback amount
            FetchCashbackAmount(walletID, planID);
        }

        private void FetchCashbackAmount(int walletID, int planID)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create the SQL command
                    SqlCommand command = new SqlCommand("SELECT dbo.Wallet_Cashback_Amount(@walletID, @planID)", connection);
                    command.CommandType = CommandType.Text;

                    // Add parameters
                    command.Parameters.AddWithValue("@walletID", walletID);
                    command.Parameters.AddWithValue("@planID", planID);

                    // Open the connection
                    connection.Open();

                    // Execute the command and get the result
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int cashbackAmount))
                    {
                        lblResult.Text = $"Total Cashback Amount: {cashbackAmount}";
                    }
                    else
                    {
                        lblResult.Text = "No cashback data found for the given inputs.";
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