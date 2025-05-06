<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="top10.aspx.cs" Inherits="milestone3esra.top10" %>

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
           <h2>View top 10 successful payment</h2>
      
        <p>
             <label for="mobile">Enter Mobile Number:</label>
            <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" CssClass="btn" />
        </p>
              </div>
        <p>
            <asp:Label ID="responseL" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
