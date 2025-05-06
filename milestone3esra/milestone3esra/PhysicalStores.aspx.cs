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
    public partial class PhysicalStores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPhysicalStores();
            }
        }

        private void LoadPhysicalStores()
        {
            string connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            // SQL Command to fetch data from the view
            SqlCommand physicalStores = new SqlCommand("SELECT * FROM [PhysicalStoreVouchers]", conn);
            physicalStores.CommandType = CommandType.Text;

            conn.Open();

            // Create a table to display data
            Table storesTable = new Table();
            storesTable.CssClass = "styled-table"; // Apply the CSS class
            TableHeaderRow headerRow = new TableHeaderRow();
            headerRow.CssClass = "header-row"; // Apply CSS for headers

            // Define the headers
            string[] headers = { "Shop ID", "working_hours", "Address", "Voucher ID", "Voucher Value" };
            foreach (string header in headers)
            {
                TableHeaderCell headerCell = new TableHeaderCell();
                headerCell.Text = header;
                headerCell.CssClass = "header-cell"; // Apply CSS for header cells
                headerRow.Cells.Add(headerCell);
            }
            storesTable.Rows.Add(headerRow);

            // Execute the SQL query and process the results
            SqlDataReader reader = physicalStores.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                // Read values
                string shopID = reader["shopID"].ToString();
                string working_hours = reader["working_hours"].ToString();
                string address = reader["address"].ToString();
                string voucherID = reader["voucherID"].ToString();
                string value = reader["value"].ToString();

                // Create a new row for each record
                TableRow row = new TableRow();
                row.CssClass = "data-row"; // Apply CSS for data rows

                row.Cells.Add(new TableCell { Text = shopID, CssClass = "data-cell" });
                row.Cells.Add(new TableCell { Text = working_hours, CssClass = "data-cell" });
                row.Cells.Add(new TableCell { Text = address, CssClass = "data-cell" });
                row.Cells.Add(new TableCell { Text = voucherID, CssClass = "data-cell" });
                row.Cells.Add(new TableCell { Text = value, CssClass = "data-cell" });

                storesTable.Rows.Add(row);
            }

            // Add the table to the form
            form1.Controls.Add(storesTable);

            conn.Close();

        }
    }
}