<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginALAA.aspx.cs" Inherits="milestone3esra.loginALAA" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        /* Page Styles */
        body {
             font-family: Arial, sans-serif;
             background-color: #FAE7F3;
            margin: 0;
            padding: 0;
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

input[type="text"], input[type="password"], .asp-textbox {
    width: 70%;
    height: 15px;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 10px; 
    outline: none;
    font-size: 14px;
    
}

input[type="text"]:focus, input[type="password"]:focus {
    border-color: #4942E4; /* Change border color on focus */
    box-shadow: 0 2px 8px rgba(73, 66, 228, 0.2); /* Adds focus effect */
}

h2{
    font-size:40px;
}

.cont{
    font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    font-size:10px;
    align-content: center;
    text-align: center; 
    }
.btn2{
     display: inline-block; 
 margin: 10px auto; 
 padding: 5px 5px;
 background-color: #4942E4;
 color: white;
 border: none;
 border-radius: 10px;
 font-size: 10px;
 cursor: pointer;
 transition: background-color 0.3s;
 font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
 text-align: center;
}
        

        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Admin Login</h2>
            <asp:Label ID="Label2" runat="server" Text="Enter Your Id:"></asp:Label><br />
            <asp:TextBox ID="adminID" runat="server" cssClass="asp-textbox"/><br />
            <asp:Label ID="Label3" runat="server" Text="Enter Your Password:"></asp:Label><br />
            <asp:TextBox ID="adminPass" runat="server" TextMode="Password" CssClass="asp-textbox" /><br />
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn" />
        </div>
        <div class="cont">
    <asp:Label ID="Label1" runat="server" Text="Not an Admin? Customer log in"></asp:Label>
    <asp:Button ID="Button2" runat="server" Text="click here" CssClass="btn2" OnClick="Button1_Click" />
</div>
    </form>
</body>
</html>
