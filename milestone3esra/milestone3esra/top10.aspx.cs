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
    public partial class top10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
                try {
                    conn.Open();
                    SqlCommand payments = new SqlCommand("[Top_Successful_Payments]", conn);
                    payments.CommandType = CommandType.StoredProcedure;
                    String mobileNo = mobile.Text;
                    string mobvalid = "SELECT COUNT(1) FROM payment WHERE mobileNo = @mobile_num";
                    SqlCommand mcmd = new SqlCommand(mobvalid, conn);
                    mcmd.Parameters.AddWithValue("@mobile_num", mobileNo);
                    int mobileExists = (int)mcmd.ExecuteScalar();

                    if (mobileExists == 0)
                    {
                        responseL.Text = "Mobile number not found. Please try another number.";
                        return;
                    }
                    else
                    {
                        payments.Parameters.AddWithValue("@mobile_num", mobileNo);

                        Table paymentTable = new Table();
                        paymentTable.CssClass = "styled-table";
                        TableHeaderRow mainlabels = new TableHeaderRow();
                        string[] headers = { "payment ID", "amount", "payment Date", "payment method", "status", "Mobile No" };
                        foreach (string header in headers)
                        {
                            TableHeaderCell headerCell = new TableHeaderCell();
                            headerCell.Text = header;
                            mainlabels.Cells.Add(headerCell);
                        }
                        paymentTable.Rows.Add(mainlabels);
                        SqlDataReader reader = payments.ExecuteReader(CommandBehavior.CloseConnection);
                        while (reader.Read())
                        {
                            String payID = (reader.GetValue(reader.GetOrdinal("paymentID"))).ToString();
                            String amount = reader.GetValue(reader.GetOrdinal("amount")).ToString();
                            String pay_date = (reader.GetDateTime(reader.GetOrdinal("date_of_payment"))).ToString();
                            String pay_method = (reader.GetString(reader.GetOrdinal("payment_method")));
                            String status = reader.GetString(reader.GetOrdinal("status"));
                            String mobileNo1 = reader.GetString(reader.GetOrdinal("mobileNo"));

                            TableRow row = new TableRow();
                            TableCell c1 = new TableCell();
                            c1.Text = payID;
                            row.Cells.Add(c1);

                            TableCell c2 = new TableCell();
                            c2.Text = amount;
                            row.Cells.Add(c2);

                            TableCell c3 = new TableCell();
                            c3.Text = pay_date;
                            row.Cells.Add(c3);

                            TableCell c4 = new TableCell();
                            c4.Text = pay_method;
                            row.Cells.Add(c4);

                            TableCell c5 = new TableCell();
                            c5.Text = status;
                            row.Cells.Add(c5);

                            TableCell c6 = new TableCell();
                            c6.Text = mobileNo1;
                            row.Cells.Add(c6);
                            paymentTable.Rows.Add(row);

                            form1.Controls.Add(paymentTable);

                        }
                    }
                }

                catch (Exception ex)
                {
                    Response.Write($"Error: {ex.Message}");
                }
        }
    }
     
}