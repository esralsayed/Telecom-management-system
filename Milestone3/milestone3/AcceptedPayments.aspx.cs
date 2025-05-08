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
    public partial class AcceptedPayments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFetchData_Click(object sender, EventArgs e)
        {
            // Get the input mobile number
            string mobileNumber = txtMobileNumber.Text.Trim();

            // Validate the input
            if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 11)
            {
                lblResult.Text = "Please enter a valid 11-digit mobile number.";
                return;
            }

            // Fetch data using the stored procedure
            FetchPaymentPointsData(mobileNumber);
        }

        private void FetchPaymentPointsData(string mobileNumber)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create the command
                    SqlCommand command = new SqlCommand("Account_Payment_Points", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the input parameter
                    command.Parameters.Add(new SqlParameter("@mobile_num", mobileNumber));

                    // Open the connection
                    connection.Open();

                    // Execute the command and read the results
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int paymentCount = reader.GetInt32(0); // First column: Payment count
                            int totalPoints = reader.IsDBNull(1) ? 0 : reader.GetInt32(1); // Second column: Total points (handle NULL)

                            // Display the result
                            lblResult.Text = $"Number of Successful Transactions: {paymentCount}<br />" +
                                             $"Total Earned Points: {totalPoints}";
                        }
                    }
                    else
                    {
                        lblResult.Text = "No data found for the given mobile number.";
                    }

                    // Close the reader
                    reader.Close();
                }
                catch (Exception ex)
                {
                    lblResult.Text = $"An error occurred: {ex.Message}";

                }
            }
        }
    }
}