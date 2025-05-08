<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WalletDetails.aspx.cs" Inherits="milestone3esra.WalletDetails" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Wallets</title>
    <style>
                                         body {
    font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #FAE7F3;
    display: flex;           
    justify-content: center; 
    align-items: center;    
    height: 100vh;          
}
        h2{
            text-align:center;
            font-size:30px;
            color:#4942E4;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
             display: block;
             margin-left: auto;
             margin-right: auto;
        }

    .gridview-style {
        width: 90%;
        margin: 0 auto;
        margin-top:20px;
        border-collapse: collapse;
        font-size: 16px;
        font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        background-color:#E6B9DE;
        color:#4942E4;
        
        margin:auto;
         width: 80%;  
        margin-left: auto;
        margin-right: auto;
        text-align: center;
        padding:10px;
       
    }

   .gridview-style th, .gridview-style td {
        padding: 10px;
        border: 1px solid #ccc;
        text-align: center;
        
    }

    .gridview-style th {
        background-color: #4942E4;
        color: white;
    }

    /*.gridview-style tr:nth-child(even) {
        background-color: #f2f2f2;
    }*/

    .gridview-style tr:hover {
        background-color: #E6B9DE;
    }

    .gridview-style .footer {
        font-weight: bold;
    }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Customer Wallets</h2>
            <asp:GridView ID="GridViewCustomerWallets" runat="server" AutoGenerateColumns="true" CssClass="gridview-style">
            </asp:GridView>
        </div>
    </form>
</body>
</html>

