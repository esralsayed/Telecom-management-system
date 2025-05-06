<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="milestone3esra.main" %>

<!DOCTYPE html>
<html>
<head>
    <title>Welcome - Telecom Management</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: linear-gradient(135deg, #FAE7F3, #E6B9DE);
            margin: 0;
            padding: 0;
           display: flex;
           flex-direction:column;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .container {
            background-color: #E6B9DE;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            padding: 30px 40px;
            text-align: center;
            width: 350px;
            margin-bottom:50px;
            border:3px solid #4942E4;
        }

        .cont{
   
   border-radius: 8px;
   box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
   padding: 30px 40px;
   text-align: left;
   width: 350px;
    color:#4942E4;
   
        }
        h1 {
    color: #11009E;
    margin-bottom: 20px;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    font-size: 28px; 
    text-transform: uppercase; 
    letter-spacing: 1.5px; 
    text-align: center; 
    border-bottom: 2px solid #4942E4; 
    padding-bottom: 10px; 
    margin-top: 30px; 
    margin-bottom:40px;
}

                h2 {
    color: #11009E;
    margin-bottom: 20px;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    font-size: 28px; 
    text-transform: uppercase; 
    letter-spacing: 1.5px; 
    text-align: center; 
    border-bottom: 2px solid #4942E4; 
    padding-bottom: 10px; 
    margin-top: 20px; 
}
        .btn {
            display: block;
            width: 100%;
            margin: 10px 0;
            padding: 10px 15px;
            background-color: #4942E4;
            color: white;
            border: none;
            border-radius: 10px;
            font-size: 20px;
            cursor: pointer;
            transition: background-color 0.3s;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;

        }
        .btn:hover {
            background-color: #11009E;
        }
        p{
            color:#11009E;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        }
        .footer{
            flex:1;
            
    color: white;
    text-align: center;
    padding: 15px 0;
    position: relative;
    bottom: 0;
    width: 100%;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    font-size: 14px;
    box-shadow: 0 -2px 5px rgba(0, 0, 0, 0.1);
        }

        .hori{
            display:flex;
            flex-direction:row;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>TELECOMMUNICATION APP</h1>
        <div class="hori">
        <div class="container">
            <h2>Welcome !</h2>
            <p>To continue, please log in:
            </p>
            <asp:Button ID="BtnCustomerLogin" runat="server" Text="Customer Login" CssClass="btn" OnClick="BtnCustomerLogin_Click" />
            <asp:Button ID="BtnAdminLogin" runat="server" Text="Admin Login" CssClass="btn" OnClick="BtnAdminLogin_Click" />
        </div>
        <div class="cont">
    <h3>Why Choose Us?</h3>
    <ul>
        <li>✔ flexible plans</li>
        <li>✔ Quick access to important data</li>
        <li>✔ 24/7 customer support</li>
        <li>✔ Excellent Offers </li>
    </ul>
</div>
            </div>
    </form>
    <div style="margin-top: 20px; font-size: 12px; color: #4942E4; text-align: center;" class="footer">
    <p>© 2024 Telecommunication App. All rights reserved.</p>
    <p><a href="privacy.html" style="color: #4942E4;">Privacy Policy</a> | <a href="terms.html" style="color: #4942E4;">Terms of Service</a></p>
</div>
</body>
</html>

