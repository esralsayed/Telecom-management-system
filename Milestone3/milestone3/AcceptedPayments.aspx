<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptedPayments.aspx.cs" Inherits="milestone3esra.AcceptedPayments" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account Payment Points</title>
    <style>
                  .container {
    background-color: #E6B9DE;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    padding: 10px 10px;
    text-align: center; 
    width: 350px;
    color: #11009E;
    align-content: center;
    font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    margin-right:auto;
    margin-left:auto;
    margin-bottom: 50px;
}

.btn {
    display: inline-block; 
    margin: 10px auto; 
    padding: 10px 15px;
    background-color: #4942E4;
    color: white;
    border: none;
    border-radius: 10px;
    font-size: 16px;
    cursor: pointer;
    transition: background-color 0.3s;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    text-align: center;
}

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Payment Transactions and Earned Points</h2>
            <label for="txtMobileNumber">Enter Mobile Number:</label>
            <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>
            <asp:Button ID="btnFetchData" runat="server" Text="Fetch Data" OnClick="btnFetchData_Click" CssClass="btn" />
            <hr />
            <asp:Label ID="lblResult" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>

