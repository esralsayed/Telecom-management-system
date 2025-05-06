<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CashbackReturned.aspx.cs" Inherits="milestone3esra.CashbackReturned" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wallet Cashback Amount</title>
    <style>
        body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #FAE7F3;
    display: flex;           
    justify-content: center; 
    align-items: center;    
    height: 100vh;          
}
.container {
    background-color: #E6B9DE;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    padding: 20px 20px;
    text-align: center;
    width: 400px;
    color: #11009E;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    margin: auto;
}

.form-row {
    display: flex;
    align-items: center;
    margin-bottom: 15px;
}

label {
    text-align: left;
    width: 150px;
    margin-right: 10px;
    font-weight: bold;
}

asp:TextBox {
    flex: 1;
    width: 100%;
    padding: 8px;
    border: 1px solid #ddd;
    border-radius: 4px;
}

.btn {
    display: block;
    margin: 20px auto;
    padding: 10px 20px;
    background-color: #4942E4;
    color: white;
    border: none;
    border-radius: 10px;
    font-size: 16px;
    cursor: pointer;
    transition: background-color 0.3s;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
}

.btn:hover {
    background-color: #3a32b2;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Retrieve Wallet Cashback Amount</h2>
            <label for="txtWalletID">Enter Wallet ID:</label>
            <asp:TextBox ID="txtWalletID" runat="server"></asp:TextBox>
            <br />
            <label for="txtPlanID">Enter Plan ID:</label>
            <asp:TextBox ID="txtPlanID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnFetchCashback" runat="server" Text="Fetch Cashback Amount" OnClick="btnFetchCashback_Click" cssClass="btn" />
            <hr />
            <asp:Label ID="lblResult" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>

