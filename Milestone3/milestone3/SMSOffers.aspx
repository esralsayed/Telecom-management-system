<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SMSOffers.aspx.cs" Inherits="milestone3esra.SMSOffers" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SMS Offers</title>
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
    display:flex;
    flex-direction:column;
    align-content:center;
    background-color: #E6B9DE;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    padding: 20px 20px;
    text-align: center;
    width: 400px;
    color: #11009E;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    margin: auto;
    justify-content: center; 
    align-items: center;
    margin-bottom:10px;
}

.form-row {
    display: flex;
    align-items: center;
    margin-bottom: 15px;
}


.text {
    flex: 1;
    width: 70%;
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

.msg{
    text-align: center; 
    font-size: 15px;
     display: block;
        margin-left: auto;
        margin-right: auto;
}

.btn:hover {
    background-color: #3a32b2;
}

    </style>
  
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>SMS offers</h1>
            <label for="mobileNoTextBox">Enter Mobile Number:</label>
            <asp:TextBox ID="mobileNoTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="fetchOffersButton" runat="server" Text="Fetch SMS Offers" OnClick="FetchOffersButton_Click" CssClass="btn" />
        </div>
        <div id="resultsContainer" class="results-container" runat="server" visible="false">
            <asp:Label ID="resultsLiteral" runat="server" ForeColor="Red" CssClass="msg"></asp:Label>
        </div>
    </form>
</body>
</html>

