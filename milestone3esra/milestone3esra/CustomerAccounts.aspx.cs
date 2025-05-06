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
    public partial class CustomerAccounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCustomerAccounts();
            }
        }

        private void LoadCustomerAccounts()
        {
            string connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand accountPlanCmd = new SqlCommand("EXEC Account_Plan", conn);
            accountPlanCmd.CommandType = CommandType.Text;

            conn.Open();

            Table accountPlanTable = new Table { CssClass = "styled-table" };
            TableHeaderRow headerRow = new TableHeaderRow { CssClass = "header-row" };


            string[] headers = { "Mobile No", "Pass", "Balance", "Account Type", "Start Date", "Status", "Points", "NationalID", "PlanID", "Plan Name", "Price", "SMS_offered", "Minutes_offered", "Data_offered", "description" };
            foreach (string header in headers)
            {
                TableHeaderCell headerCell = new TableHeaderCell { CssClass = "header-cell" };
                headerCell.Text = header;
                headerRow.Cells.Add(headerCell);
            }
            accountPlanTable.Rows.Add(headerRow);

            SqlDataReader reader = accountPlanCmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string mobileNo = reader["mobileNo"].ToString();
                string pass = reader["pass"].ToString();
                string balance = reader["balance"].ToString();
                string accountType = reader["account_type"].ToString();
                string startDate = Convert.ToDateTime(reader["start_date"]).ToString("yyyy-MM-dd");
                string status = reader["status"].ToString();
                string points = reader["points"].ToString();
                string nationalID = reader["nationalID"].ToString();
                string planID = reader["planID"].ToString();
                string name = reader["name"].ToString();
                string price = reader["price"].ToString();
                string SMS_offered = reader["SMS_offered"].ToString();
                string minutes_offered = reader["minutes_offered"].ToString();
                string data_offered = reader["data_offered"].ToString();
                string description = reader["description"].ToString();


                // Create a row to display the customer and service plan details
                TableRow row = new TableRow { CssClass = "data-row" };

                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = mobileNo });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = pass });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = balance });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = accountType });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = startDate });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = status });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = points });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = nationalID });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = planID });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = name });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = price });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = SMS_offered });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = minutes_offered });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = data_offered });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = description });

                // Add the row to the table
                accountPlanTable.Rows.Add(row);
            }

            // Add the table to the page's form
            form1.Controls.Add(accountPlanTable);
        }

    }
}
