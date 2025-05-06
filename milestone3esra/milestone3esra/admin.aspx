<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="milestone3esra.admin" %>

<!DOCTYPE html>
<html>
<head>
    <title>Telecom Customer Management</title>
    <style>
        body {
             font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
             background-color: #FAE7F3;
            margin: 0;
            padding: 0;
            height: 100vh;
            
        }
.container {
    background-color: #E6B9DE;
    width: 100%;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    padding: 5px; 
    max-width: 1200px; 
    color: #11009E;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    display: grid; 
   grid-template-columns: repeat(auto-fit, minmax(200px, 1fr)); /* Dynamic columns */
    gap: 20px; 
    margin: 0 auto;
}

.btn {
    padding: 10px 15px;
    background-color: #4942E4;
    color: white;
    border: none;
    border-radius: 10px;
    font-size: 14px;
    cursor: pointer;
    transition: background-color 0.3s;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    text-align: center;
    width: 100%; 
    height: 50px;
    max-width: 250px; 
    box-sizing: border-box; 
    white-space: normal; 
    word-wrap: break-word; 

}
 .btn:hover {
     background-color: #11009E;
     transform: scale(1.05); 
 }

h1{
    color:#E6B9DE; 
    display:block;
    margin:0;
    margin-left:auto;
    margin-right:auto;
    text-align:center;
}

h2{
    color:#4942E4; 
    display:block;
    margin:0;
    margin-left:auto;
    margin-right:auto;
    text-align:center;
}

.header {
    text-align: center;
    background-color: #4942E4;
    color: white;
    padding: 20px 0;
    border-radius: 8px;
    margin-bottom: 20px;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
}

.btn2 {
            padding: 10px 15px;
            background-color: #4942E4;
            color: white;
            border: none;
            border-radius: 5px;
            font-size: 10px;
            cursor: pointer;
            transition: background-color 0.3s;
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            text-align: center;
            align-content:center;
        }

        .btn2:hover {
            background-color: #11009E;
            transform: scale(1.05); 
        }

       
        .back-button-container {
            display: flex;
            justify-content: center;
            margin-top: 20px;
        }


    </style>
</head>
<body>
    <header class="header">
    <h1>Admin Dashboard</h1>
    <p>Welcome to the Telecom Customer Management System</p>
</header>


    <form id="form1" runat="server">
        <h2>Customer Management</h2>
        <div class="container">
            
            <asp:Button ID="BtnCustomerProfiles" runat="server" Text="View Customer Profiles" CssClass="btn" OnClick="BtnCustomerProfiles_Click" />
            <asp:Button ID="BtnPhysicalStores" runat="server" Text="View Physical Stores" CssClass="btn" OnClick="BtnPhysicalStores_Click" />
            <asp:Button ID="BtnResolvedTickets" runat="server" Text="View Resolved Tickets" CssClass="btn" OnClick="BtnResolvedTickets_Click" />
            <asp:Button ID="BtnCustomerAccounts" runat="server" Text="View Customer Accounts" CssClass="btn" OnClick="BtnCustomerAccounts_Click" />
            <asp:Button ID="BtnAccountsByPlan" runat="server" Text="Accounts by Plan" CssClass="btn" OnClick="BtnAccountsByPlan_Click" />
            <asp:Button ID="BtnTotalUsage" runat="server" Text="Show Total Usage" CssClass="btn" OnClick="BtnTotalUsage_Click" />
            <asp:Button ID="BtnRemoveBenefits" runat="server" Text="Remove Benefits" CssClass="btn" OnClick="BtnRemoveBenefits_Click" />
            <asp:Button ID="BtnSMSOffers" runat="server" Text="List SMS Offers" CssClass="btn" OnClick="BtnSMSOffers_Click" />
            <asp:Button ID="BtnWalletDetails" runat="server" Text="View Wallet Details" CssClass="btn" OnClick="BtnWalletDetails_Click" />
            <asp:Button ID="BtnEShops" runat="server" Text="View E-Shops and Vouchers" CssClass="btn" OnClick="BtnEShops_Click" />
            <asp:Button ID="BtnPayments" runat="server" Text="View Payments" CssClass="btn" OnClick="BtnPayments_Click" />
            <asp:Button ID="BtnCashbackCount" runat="server" Text="Wallet Cashback Count" CssClass="btn" OnClick="BtnCashbackCount_Click" />
            <asp:Button ID="BtnAcceptedPayments" runat="server" Text="Accepted Payments & Points" CssClass="btn" OnClick="BtnAcceptedPayments_Click" />
            <asp:Button ID="BtnCashbackReturned" runat="server" Text="Cashback Returned" CssClass="btn" OnClick="BtnCashbackReturned_Click" />
            <asp:Button ID="BtnAverageTransaction" runat="server" Text="Average Transaction Amount" CssClass="btn" OnClick="BtnAverageTransaction_Click" />
            <asp:Button ID="BtnWalletLinked" runat="server" Text="Check Wallet Link" CssClass="btn" OnClick="BtnWalletLinked_Click" />
            <asp:Button ID="BtnUpdatePoints" runat="server" Text="Update Earned Points" CssClass="btn" OnClick="BtnUpdatePoints_Click" />
        </div>
        <div class="back-button-container">
                <asp:Button ID="Button1" runat="server" Text="Back to Home Page" OnClick="Button1_Click" CssClass="btn2" />
</div>
    </form>
</body>
</html>

