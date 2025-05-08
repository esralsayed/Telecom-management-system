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
    public partial class TotalUsage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FetchUsageButton_Click(object sender, EventArgs e)
        {
            string mobileNumber = mobileNoTextBox.Text.Trim();
            string startDateInput = startDateTextBox.Text.Trim();

            // Validate inputs
            if (mobileNumber.Length == 11 && DateTime.TryParse(startDateInput, out DateTime startDate))
            {
                string connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                try
                {
                    // Use the Account_Usage_Plan function
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Account_Usage_Plan(@mobile_num, @start_date)", conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("@mobile_num", mobileNumber));
                    cmd.Parameters.Add(new SqlParameter("@start_date", startDate));

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Create a table dynamically to display results
                    Table resultTable = new Table { CssClass = "styled-table" };
                    TableHeaderRow headerRow = new TableHeaderRow();

                    // Define headers
                    string[] headers = { "Plan ID", "Total Data (MB)", "Total Minutes", "Total SMS" };
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

                        row.Cells.Add(new TableCell { Text = reader["planID"].ToString() });
                        row.Cells.Add(new TableCell { Text = reader["total data"].ToString() });
                        row.Cells.Add(new TableCell { Text = reader["total mins"].ToString() });
                        row.Cells.Add(new TableCell { Text = reader["total SMS"].ToString() });

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
                Response.Write("<script>alert('Invalid input. Please enter a valid mobile number and date.');</script>");

            }
        }
    }
}