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
    public partial class AccountsByPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Actions on initial page load can go here.
        }

        protected void FetchAccounts_Click(object sender, EventArgs e)
        {
            // Fetch input values
            string subscriptionDate = subscriptionDateTextBox.Text.Trim();
            string planIdInput = planIDTextBox.Text.Trim();

            if (DateTime.TryParse(subscriptionDate, out DateTime parsedDate) && int.TryParse(planIdInput, out int planId))
            {
                string connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                try
                {
                    // Call the Account_Plan_date function
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Account_Plan_date(@sub_date, @plan_id)", conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("@sub_date", parsedDate));
                    cmd.Parameters.Add(new SqlParameter("@plan_id", planId));

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Create a table dynamically to display results
                    Table resultTable = new Table { CssClass = "styled-table" };
                    TableHeaderRow headerRow = new TableHeaderRow();

                    // Define headers
                    string[] headers = { "Mobile No", "Plan ID", "Plan Name" };
                    foreach (string header in headers)
                    {
                        TableHeaderCell headerCell = new TableHeaderCell { Text = header };
                        headerRow.Cells.Add(headerCell);
                    }
                    resultTable.Rows.Add(headerRow);

                    // Fill table rows with data
                    while (reader.Read())
                    {
                        TableRow row = new TableRow();

                        row.Cells.Add(new TableCell { Text = reader["mobileNo"].ToString() });
                        row.Cells.Add(new TableCell { Text = reader["planID"].ToString() });
                        row.Cells.Add(new TableCell { Text = reader["name"].ToString() });

                        resultTable.Rows.Add(row);
                    }

                    reader.Close();

                    // Add the result table to the form dynamically
                    form1.Controls.Add(resultTable);
                }
                catch (Exception ex)
                {
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid input. Please enter a valid date and plan ID.');</script>");

            }
        }
    }
}