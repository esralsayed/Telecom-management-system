<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginMENNA.aspx.cs" Inherits="milestone3esra.loginMENNA" %>
<link href="style/styles.css" rel="stylesheet" type="text/css" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
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
    height: 30px;
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
        <asp:Label ID="responseL" runat="server" ForeColor="Red" CssClass="msg"></asp:Label>
        <div class="container">
        <h2>Customer login</h2>
        <asp:Label ID="Label1" runat="server" Text="Mobile Number"></asp:Label>   <br />
        <asp:TextBox ID="mobile" runat="server" CssClass="asp-textbox"></asp:TextBox>
        <br />
         <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><br />
        <asp:TextBox ID="pass" runat="server" CssClass="asp-textbox"></asp:TextBox>
        <br />
        <asp:Button CssClass="btn" ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
        </div>
        <div class="cont">
            <asp:Label ID="Label3" runat="server" Text="Not a Customer? Admin log in"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="click here" CssClass="btn2" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
