<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="ProductsClient.ProductsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="GetProducts_Button" OnClick="GetProducts_Button_Click" runat="server" Text="Get products" />
    </div>
    </form>
    
</body>
</html>
