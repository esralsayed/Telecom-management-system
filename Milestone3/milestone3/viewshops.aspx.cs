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
    public partial class viewshops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand shops = new SqlCommand("SELECT * FROM [allShops]", conn);
            shops.CommandType = CommandType.Text;

            conn.Open();
            Table shopsTable = new Table();
            shopsTable.CssClass = "styled-table";
            TableHeaderRow mainlabels = new TableHeaderRow();
            string[] headers = { "Shop ID", "Name", "Category" };
            foreach (string header in headers)
            {
                TableHeaderCell headerCell = new TableHeaderCell();
                headerCell.Text = header;
                mainlabels.Cells.Add(headerCell);
            }
            shopsTable.Rows.Add(mainlabels);

            SqlDataReader reader = shops.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                String shopID = (reader.GetValue(reader.GetOrdinal("shopID"))).ToString();
                String name = reader.GetString(reader.GetOrdinal("name"));
                String category = reader.GetString(reader.GetOrdinal("category"));

                TableRow row = new TableRow();

                TableCell c1 = new TableCell();
                c1.Text = shopID;
                row.Cells.Add(c1);

                TableCell c2 = new TableCell();
                c2.Text = name;
                row.Cells.Add(c2);

                TableCell c3 = new TableCell();
                c3.Text = category;
                row.Cells.Add(c3);

                shopsTable.Rows.Add(row);
            }

            // Add the table to the form after all rows are created
            form1.Controls.Add(shopsTable);
        }
    }
}