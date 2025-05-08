<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AverageTransaction.aspx.cs" Inherits="milestone3esra.AverageTransaction" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wallet Transfer Average</title>
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
label {
    text-align: center; /* Ensures text alignment is left */
    display: inline-block; /* Ensures proper layout control */
    width: 150px; /* Fixed width for consistent alignment */
    margin-right: 10px;
    font-weight: bold;
    vertical-align: middle; /* Aligns text vertically with inputs */
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
.cont{
    margin-bottom:10px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Retrieve Average Transfer Amount</h2>
            <div class="cont">
            <label for="txtWalletID">Enter Wallet ID:</label>
            <asp:TextBox ID="txtWalletID" runat="server"></asp:TextBox>
            </div>
            <br />
            <div class="cont">
            <label for="txtStartDate">Enter Start Date (YYYY-MM-DD):</label>
            <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date"></asp:TextBox>
            <br />
                </div>
            <div class="cont">
            <label for="txtEndDate">Enter End Date (YYYY-MM-DD):</label>
            <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            </div>
            <asp:Button ID="btnFetchAverage" runat="server" Text="Fetch Average" OnClick="btnFetchAverage_Click" CssClass="btn" />
            <hr />
            <asp:Label ID="lblResult" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>

