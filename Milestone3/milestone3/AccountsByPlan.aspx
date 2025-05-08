<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountsByPlan.aspx.cs" Inherits="milestone3esra.AccountsByPlan" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account Plan Subscription Details</title>
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
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .input-box {
            width: 70%;
            padding: 8px;
            margin-bottom: 15px;
            border: 1px solid #ddd;
            border-radius: 4px;
        }

        .input-box:focus {
            border-color: #007BFF;
            outline: none;
        }

        .btn-submit {
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

        .btn-submit:hover {
            background-color: #0056b3;
        }

.styled-table {
    width: 100%;
    border-collapse: collapse; 
    margin: 20px 0;
    font-size: 16px;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    border: 2px solid #4942E4; 
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); 
}

.styled-table th, 
.styled-table td {
    padding: 12px;
    text-align: center;
    border: 1px solid #4942E4;
}

.styled-table th {
    background-color: #4942E4;
    color: white;
    font-weight: bold;
}

.styled-table td {
    background-color: #E6B9DE;
    color: #4942E4;
}

.styled-table tr:hover {
    background-color: #ddd;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Account Subscription Details</h2>

            <label for="subscriptionDateTextBox">Subscription Date:</label>
            <asp:TextBox ID="subscriptionDateTextBox" runat="server" CssClass="input-box" Placeholder="YYYY-MM-DD" TextMode="Date"></asp:TextBox>

            <label for="planIDTextBox">Plan ID:</label>
            <asp:TextBox ID="planIDTextBox" runat="server" CssClass="input-box" Placeholder="Enter Plan ID"></asp:TextBox>

            <asp:Button ID="fetchAccountsButton" runat="server" Text="Fetch Accounts" CssClass="btn-submit" OnClick="FetchAccounts_Click" />
        </div>
    </form>
</body>
</html>

