<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerProfiles.aspx.cs" Inherits="milestone3esra.CustomerProfiles" %>

<!DOCTYPE html>
<html>
<head>
    <title>Customer Profiles</title>
  <style>
.styled-table {
    width: 100%;
    border-collapse: collapse; /* Ensures no gaps between cells */
    margin: 20px 0;
    font-size: 16px;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    border: 2px solid #4942E4; /* Border around the table */
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); /* Optional shadow for aesthetics */
}

.styled-table th, 
.styled-table td {
    padding: 12px;
    text-align: center;
    border: 1px solid #4942E4; /* Cell borders */
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
h1{
    text-align:center;
    font-size:30px;
    color:#4942E4;
    font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
     display: block;
     margin-left: auto;
     margin-right: auto;
}
</style>

</head>
<body>
    <form id="form1" runat="server">
        <h1>All customer Profiles</h1>
        <div>
            
        </div>
    </form>
</body>
</html>

