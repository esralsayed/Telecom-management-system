<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="options.aspx.cs" Inherits="milestone3esra.options" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {
             font-family: Arial, sans-serif;
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
    padding: 20px; 
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
 }

h1{
    color:#E6B9DE; 
    display:block;
    margin:0;
}
h2{
    color:#4942E4; 
display:block;
margin:0;
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
    <title>Options</title>
</head>
<body>
        <header class="header">
    <h1>Customer Dashboard</h1>
    <p>Welcome to the Telecommunication App</p>
</header>
    <form id="form1" runat="server">
        <h2 id="greeting" runat="server"></h2>
        <div class="container">
           
            <asp:Button CssClass="btn" ID="servicePlans" runat="server" Text="View All Service Plans" OnClick="servicePlans_Click" />
            <asp:Button CssClass="btn" ID="smsInternet" runat="server" Text="View Plan Consumption" OnClick="smsInternet_Click" />
            <asp:Button CssClass="btn" ID="unsub" runat="server" Text="View Unsubscribed Plans" OnClick="unsub_Click" />
            <asp:Button CssClass="btn" ID="currMonth" runat="server" Text="Current Month Usage" OnClick="currMonth_Click" />
            <asp:Button CssClass="btn" ID="cashback" runat="server" Text="Cashback Transactions" OnClick="cashback_Click" />
            <asp:Button CssClass="btn" ID="benefits" runat="server" Text="Active Benefits" OnClick="benefits_Click" />
            <asp:Button CssClass="btn" ID="unresolved" runat="server" Text="Unresolved Technical Tickets" OnClick="unresolved_Click" />
            <asp:Button CssClass="btn" ID="highestVoucher" runat="server" Text="Highest Value Voucher" OnClick="highestVoucher_Click" />
            <asp:Button CssClass="btn" ID="remainingAmount" runat="server" Text="Remaining Payment Amount" OnClick="remainingAmount_Click" />
            <asp:Button CssClass="btn" ID="extraAmount" runat="server" Text="Extra Payment Amount" OnClick="extraAmount_Click" />
            <asp:Button CssClass="btn" ID="top10Payments" runat="server" Text="Top 10 Successful Payments" OnClick="top10Payments_Click" />
            <asp:Button CssClass="btn" ID="allShops" runat="server" Text="View All Shops" OnClick="allShops_Click" />
            <asp:Button CssClass="btn" ID="past5MonthsPlans" runat="server" Text="Subscribed Plans in Past 5 Months" OnClick="past5MonthsPlans_Click" />
            <asp:Button CssClass="btn" ID="renewSub" runat="server" Text="Renew Plan Subscription" OnClick="renewSub_Click"/>
            <asp:Button CssClass="btn" ID="benefitCashback" runat="server" Text="Get Benefit Cashback" OnClick="benefitCashback_Click"  />
            <asp:Button CssClass="btn" ID="rechargeBalance" runat="server" Text="Recharge Balance" OnClick="rechargeBalance_Click" />
            <asp:Button CssClass="btn" ID="redeemVoucher" runat="server" Text="Redeem a Voucher" OnClick="redeemVoucher_Click" />
        </div>
                <div class="back-button-container">
                <asp:Button ID="Button1" runat="server" Text="Back to Home Page" OnClick="Button1_Click" CssClass="btn2" />
</div>
    </form>
</body>
</html>
