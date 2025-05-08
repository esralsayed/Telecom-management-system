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
    public partial class CustomerProfiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCustomerProfiles();
            }


        }

        private void LoadCustomerProfiles()
        {
            string connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand customerProfilesCmd = new SqlCommand("SELECT * FROM [allCustomerAccounts]", conn);
            customerProfilesCmd.CommandType = CommandType.Text;

            conn.Open();

            Table profilesTable = new Table { CssClass = "styled-table" };
            TableHeaderRow headerRow = new TableHeaderRow { CssClass = "header-row" };

            string[] headers = { "National ID", "first_ame", "last_name", "Email", "address", "date_of_birth", "Mobile No", "Account Type", "Status", "Start Date", "Balance", "Points" };
            foreach (string header in headers)
            {
                TableHeaderCell headerCell = new TableHeaderCell { CssClass = "header-cell" };
                headerCell.Text = header;
                headerRow.Cells.Add(headerCell);
            }
            profilesTable.Rows.Add(headerRow);

            SqlDataReader reader = customerProfilesCmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string nationalID = reader["nationalID"].ToString();
                string first_name = reader["first_name"].ToString();
                string last_name = reader["last_name"].ToString();
                string email = reader["email"].ToString();
                string address = reader["address"].ToString();
                string date_of_birth = reader["date_of_birth"].ToString();
                string mobileNo = reader["mobileNo"].ToString();
                string accountType = reader["account_type"].ToString();
                string status = reader["status"].ToString();
                string startDate = Convert.ToDateTime(reader["start_date"]).ToString("yyyy-MM-dd");
                string balance = reader["balance"].ToString();
                string points = reader["points"].ToString();

                TableRow row = new TableRow { CssClass = "styled-table" };

                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = nationalID });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = first_name });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = last_name });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = email });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = date_of_birth });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = address });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = mobileNo });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = accountType });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = status });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = startDate });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = balance });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = points });

                profilesTable.Rows.Add(row);
            }

            form1.Controls.Add(profilesTable);
        }


    }
}
