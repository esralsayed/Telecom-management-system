<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="remaining.aspx.cs" Inherits="milestone3esra.remaining" %>

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

.btn:hover {
    background-color: #3a32b2;
}

.msg{
    text-align: center; 
    font-size: 15px;
     display: block;
        margin-left: auto;
        margin-right: auto;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>to view your payment remaining amount</h2>
            <label for="mobile">Enter Mobile Number:</label>
            <asp:TextBox ID="mobile" runat="server" CssClass="text"></asp:TextBox>

        </br>
            <label for="plan">Enter Plan Name:</label>   
            <asp:TextBox ID="plan" runat="server" CssClass="text"></asp:TextBox>
        </br>
            <asp:Button ID="Button1" runat="server" Text="enter" OnClick="Button1_Click" CssClass="btn" />
            </div>
        
        <asp:Label ID="responseL" runat="server" ForeColor="Red" CssClass="msg"></asp:Label>
        <asp:Label ID="responseR" runat="server" ForeColor="Green" CssClass="msg"></asp:Label>
    </form>
</body>
</html>
