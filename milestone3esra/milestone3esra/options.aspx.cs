using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3esra
{
    public partial class options : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["CustomerName"] != null)
                {
                    string customerName = Session["CustomerName"].ToString();
                    greeting.InnerText = $"Hi {customerName}!";
                }

            }
        }
            protected void servicePlans_Click(object sender, EventArgs e)
            {
                Response.Redirect("allServicePlansMENNA.aspx");
            }

            protected void smsInternet_Click(object sender, EventArgs e)
            {
                Response.Redirect("SMSminsInternetMENNA.aspx");
            }

            protected void unsub_Click(object sender, EventArgs e)
            {
                Response.Redirect("NotSubscribedMENNA.aspx");
            }

            protected void currMonth_Click(object sender, EventArgs e)
            {
                Response.Redirect("currentMonthUsageMENNA.aspx");
            }

            protected void cashback_Click(object sender, EventArgs e)
            {
                Response.Redirect("cashbackNatIDMENNA.aspx");
            }

            protected void benefits_Click(object sender, EventArgs e)
            {
                Response.Redirect("benefits.aspx");
            }

            protected void unresolved_Click(object sender, EventArgs e)
            {
                Response.Redirect("NotResolved.aspx");
            }

            protected void highestVoucher_Click(object sender, EventArgs e)
            {
                Response.Redirect("highestVoucher.aspx");
            }

            protected void remainingAmount_Click(object sender, EventArgs e)
            {
                Response.Redirect("remaining.aspx");
            }

            protected void extraAmount_Click(object sender, EventArgs e)
            {
                Response.Redirect("extra.aspx");
            }

            protected void top10Payments_Click(object sender, EventArgs e)
            {
                Response.Redirect("top10.aspx");
            }

            protected void allShops_Click(object sender, EventArgs e)
            {
                Response.Redirect("viewshops.aspx");
            }

            protected void past5MonthsPlans_Click(object sender, EventArgs e)
            {
                Response.Redirect("pastPlans5months.aspx");
            }

            protected void renewSub_Click(object sender, EventArgs e)
            {
                Response.Redirect("renewplan.aspx");
            }

            protected void benefitCashback_Click(object sender, EventArgs e)
            {
                Response.Redirect("cashbackbenefit.aspx");
            }

            protected void rechargeBalance_Click(object sender, EventArgs e)
            {
                Response.Redirect("recharge.aspx");
            }

            protected void redeemVoucher_Click(object sender, EventArgs e)
            {
                Response.Redirect("redeem.aspx");
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");

        }
    }
    }
