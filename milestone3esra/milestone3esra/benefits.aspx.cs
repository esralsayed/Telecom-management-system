using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.SqlServer.Server;

namespace milestone3esra
{
    public partial class benefits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand benefits = new SqlCommand("SELECT * FROM [allBenefits]", conn);
            benefits.CommandType = CommandType.Text;

            conn.Open();
            Table benefitsTable = new Table();
            benefitsTable.CssClass = "styled-table";
            TableHeaderRow mainlabels = new TableHeaderRow();

            string[] headers = { "Benefit ID", "Description", "Validity Date", "Status", "Mobile No" };
            foreach(string header in headers)
            {
                TableHeaderCell headerCell = new TableHeaderCell();
                headerCell.Text = header;
                mainlabels.Cells.Add(headerCell);
            }
            benefitsTable.Rows.Add(mainlabels);
            SqlDataReader reader= benefits.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                String benefitID = (reader.GetValue(reader.GetOrdinal("benefitID"))).ToString();
                String description = reader.GetString(reader.GetOrdinal("description"));
                String validity_date = (reader.GetDateTime(reader.GetOrdinal("validity_date"))).ToString();
                String status = reader.GetString(reader.GetOrdinal("status"));
                String mobileNo = reader.GetString(reader.GetOrdinal("mobileNo"));

                TableRow row = new TableRow();
                TableCell c1 = new TableCell();
                c1.Text = benefitID;
                row.Cells.Add(c1);

                TableCell c2 = new TableCell();
                c2.Text = description;
                row.Cells.Add(c2);

                TableCell c3 = new TableCell();
                c3.Text = validity_date;
                row.Cells.Add(c3);

                TableCell c4 = new TableCell();
                c4.Text = status;
                row.Cells.Add(c4);

                TableCell c5 = new TableCell();
                c5.Text = mobileNo;
                row.Cells.Add(c5);
                benefitsTable.Rows.Add(row);

                form1.Controls.Add(benefitsTable);


            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("options.aspx");
        }
    }
}