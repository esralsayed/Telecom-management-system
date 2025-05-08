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
    public partial class UpdatePoints : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdatePoints_Click(object sender, EventArgs e)
        {
            // Get the input mobile number
            string mobileNumber = txtMobileNumber.Text.Trim();

            // Validate the input
            if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 11)
            {
                lblResult.Text = "Please enter a valid 11-digit mobile number.";
                return;
            }

            // Execute the stored procedure
            UpdateTotalPoints(mobileNumber);
        }

        private void UpdateTotalPoints(string mobileNumber)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Create the SQL command
                    SqlCommand command = new SqlCommand("Total_Points_Account", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the input parameter
                    command.Parameters.AddWithValue("@mobile_num", mobileNumber);

                    // Open the connection
                    connection.Open();

                    // Execute the stored procedure
                    int rowsAffected = command.ExecuteNonQuery();

                    // Display success message
                    lblResult.Text = rowsAffected > 0
                        ? "The total points have been updated successfully."
                        : "No updates were made. Please check the mobile number.";
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