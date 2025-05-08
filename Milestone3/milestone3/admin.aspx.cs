using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace milestone3esra
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCustomerProfiles_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerProfiles.aspx");
        }

        protected void BtnPhysicalStores_Click(object sender, EventArgs e)
        {
            Response.Redirect("PhysicalStores.aspx");
        }

        protected void BtnResolvedTickets_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResolvedTickets.aspx");
        }

        protected void BtnCustomerAccounts_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAccounts.aspx");
        }

        protected void BtnAccountsByPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountsByPlan.aspx");
        }

        protected void BtnTotalUsage_Click(object sender, EventArgs e)
        {
            Response.Redirect("TotalUsage.aspx");
        }

        protected void BtnRemoveBenefits_Click(object sender, EventArgs e)
        {
            Response.Redirect("RemoveBenefits.aspx");
        }

        protected void BtnSMSOffers_Click(object sender, EventArgs e)
        {
            Response.Redirect("SMSOffers.aspx");
        }

        protected void BtnWalletDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("WalletDetails.aspx");
        }

        protected void BtnEShops_Click(object sender, EventArgs e)
        {
            Response.Redirect("EShops.aspx");
        }

        protected void BtnPayments_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payments.aspx");
        }

        protected void BtnCashbackCount_Click(object sender, EventArgs e)
        {
            Response.Redirect("CashbackCount.aspx");
        }

        protected void BtnAcceptedPayments_Click(object sender, EventArgs e)
        {
            Response.Redirect("AcceptedPayments.aspx");
        }

        protected void BtnCashbackReturned_Click(object sender, EventArgs e)
        {
            Response.Redirect("CashbackReturned.aspx");
        }

        protected void BtnAverageTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("AverageTransaction.aspx");
        }

        protected void BtnWalletLinked_Click(object sender, EventArgs e)
        {
            Response.Redirect("WalletLinked.aspx");
        }

        protected void BtnUpdatePoints_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePoints.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
    }
}