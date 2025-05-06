using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3esra
{
    public partial class SMSOffers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FetchOffersButton_Click(object sender, EventArgs e)
        {
            string mobileNumber = mobileNoTextBox.Text.Trim();

            if (mobileNumber.Length == 11)
            {
                string connStr = WebConfigurationManager.ConnectionStrings["mydb"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Account_SMS_Offers(@mobile_num)", conn);
                    cmd.Parameters.Add(new SqlParameter("@mobile_num", mobileNumber));

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        resultsLiteral.Text = GenerateResultsTable(reader);
                        resultsContainer.Visible = true;
                    }
                    else
                    {
                        resultsLiteral.Text = "<p>No SMS offers found for this account.</p>";
                        resultsContainer.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    resultsLiteral.Text = $"<p>Error: {ex.Message}</p>";
                    resultsContainer.Visible = true;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                resultsLiteral.Text = "<p>Invalid mobile number. Please enter an 11-digit number.</p>";
                resultsContainer.Visible = true;
            }
        }

        private string GenerateResultsTable(SqlDataReader reader)
        {
            string tableHtml = "<table><thead><tr>";

            // Generate headers
            for (int i = 0; i < reader.FieldCount; i++)
            {
                tableHtml += $"<th>{reader.GetName(i)}</th>";
            }
            tableHtml += "</tr></thead><tbody>";

            // Generate rows
            while (reader.Read())
            {
                tableHtml += "<tr>";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    tableHtml += $"<td>{reader.GetValue(i)}</td>";
                }
                tableHtml += "</tr>";
            }

            tableHtml += "</tbody></table>";
            return tableHtml;

        }
    }
}