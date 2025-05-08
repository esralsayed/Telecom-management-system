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
    public partial class ResolvedTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadResolvedTickets();
            }
        }

        private void LoadResolvedTickets()
        {
            string connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand resolvedTicketsCmd = new SqlCommand("SELECT * FROM [allResolvedTickets]", conn);
            resolvedTicketsCmd.CommandType = CommandType.Text;

            conn.Open();

            Table ticketsTable = new Table { CssClass = "styled-table" };
            TableHeaderRow headerRow = new TableHeaderRow { CssClass = "header-row" };

            string[] headers = { "Ticket ID", "mobileNo", "Issue Description", "priority_level", "Status" };
            foreach (string header in headers)
            {
                TableHeaderCell headerCell = new TableHeaderCell { CssClass = "header-cell" };
                headerCell.Text = header;
                headerRow.Cells.Add(headerCell);
            }
            ticketsTable.Rows.Add(headerRow);

            SqlDataReader reader = resolvedTicketsCmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string ticketID = reader["ticketID"].ToString();
                string mobileNo = reader["mobileNo"].ToString();
                string issueDescription = reader["issue_description"].ToString();
                string priority_level = reader["priority_level"].ToString();

                string status = reader["status"].ToString();

                TableRow row = new TableRow { CssClass = "data-row" };

                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = ticketID });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = mobileNo });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = issueDescription });
                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = priority_level });

                row.Cells.Add(new TableCell { CssClass = "data-cell", Text = status });

                ticketsTable.Rows.Add(row);
            }

            form1.Controls.Add(ticketsTable);

        }
    }
}