<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CashbackCount.aspx.cs" Inherits="milestone3esra.CashbackCount" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Number of Cashback Transactions</title>
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

    .gridview-style {
        width: 90%;
        margin: 0 auto;
        border-collapse: collapse;
        font-size: 16px;
        font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        background-color:#E6B9DE;
        color:#4942E4;
        border-radius:10px;
        margin:auto;
         width: 80%;  
        margin-left: auto;
        margin-right: auto;
        text-align: center;
       
    }

   .gridview-style th, .gridview-style td {
        padding: 10px;
        border: 1px solid #ccc;
        text-align: center;
        border-radius:10px;
    }

    .gridview-style th {
        background-color: #4942E4;
        color: white;
    }

    /*.gridview-style tr:nth-child(even) {
        background-color: #f2f2f2;
    }*/

    .gridview-style tr:hover {
        background-color: #dcdcdc;
    }

    .gridview-style .footer {
        font-weight: bold;
    }

        .container {
           
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            padding: 10px 10px;
            text-align: center;
        
            
            align-content: center;
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        }

        h2{
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; 
            font-size:30px;
            margin-left:auto;
            margin-right:auto; 
            text-align:center;
            color:#4942E4;
        }
        </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Total Cashback Transactions by Wallet</h2>
            <asp:GridView ID="GridViewCashback" runat="server" AutoGenerateColumns="true" CssClass="gridview-style">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
