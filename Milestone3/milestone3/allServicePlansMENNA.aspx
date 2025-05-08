<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="allServicePlansMENNA.aspx.cs" Inherits="milestone3esra.allServicePlansMENNA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {
    font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
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

    .gridview-style {
        width: 90%;
        margin: 0 auto;
        border-collapse: collapse;
        font-size: 16px;
        font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        background-color:#E6B9DE;
        color:#4942E4;
      
        margin:auto;
         width: 80%;  
        margin-left: auto;
        margin-right: auto;
        text-align: center;
       
    }

   .gridview-style th, .gridview-style td {
        padding: 10px;
        border: 2px solid #4942E4;
        text-align: center;
      
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

        .container {
           
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            padding: 10px 10px;
            text-align: center;
        
            
            align-content: center;
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        }

    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <h1>Offered Service Plans:</h1>
        <div class="container">
            
            <br />
            <asp:GridView ID="serviceGrid" runat="server" CssClass="gridview-style">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
