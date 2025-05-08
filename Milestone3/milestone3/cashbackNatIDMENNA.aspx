<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cashbackNatIDMENNA.aspx.cs" Inherits="milestone3esra.cashbackNatIDMENNA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>View your cashback transactions</h2>
            <asp:Label ID="Label1" runat="server" Text="Please enter your national ID"></asp:Label>
            <br />
            <asp:TextBox ID="nationalID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="cashback" runat="server" Text="View Cashback Transactions" OnClick="Button1_Click" CssClass="btn" />
            <br />
            <asp:GridView ID="cashbackGrid" runat="server" CssClass="gridview-style">
            </asp:GridView>
        </div>
    </form>
</body>
</html>

