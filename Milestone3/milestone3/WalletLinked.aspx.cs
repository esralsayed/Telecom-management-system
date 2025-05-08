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
    public partial class WalletLinked : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckWallet_Click(object sender, EventArgs e)
        {
            // Get the input mobile number
            string mobileNumber = txtMobileNumber.Text.Trim();

            // Validate the input
            if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 11)
            {
                lblResult.Text = "Please enter a valid 11-digit mobile number.";
                return;
            }

            // Check if the mobile number is linked to a wallet
            CheckWalletLink(mobileNumber);
        }

        private void CheckWalletLink(string mobileNumber)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create the SQL command
                    SqlCommand command = new SqlCommand("SELECT dbo.Wallet_MobileNo(@mobile_num)", connection);
                    command.CommandType = CommandType.Text;

                    // Add the input parameter
                    command.Parameters.AddWithValue("@mobile_num", mobileNumber);

                    // Open the connection
                    connection.Open();

                    // Execute the command and get the result
                    object result = command.ExecuteScalar();

                    if (result != null && bool.TryParse(result.ToString(), out bool isLinked))
                    {
                        lblResult.Text = isLinked
                            ? "This mobile number is linked to a wallet."
                            : "This mobile number is not linked to any wallet.";
                    }
                    else
                    {
                        lblResult.Text = "Unexpected error occurred.";
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