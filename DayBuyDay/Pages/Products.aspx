<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="DayBuyDay.Pages.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/ProductsPage.css" rel="stylesheet" />
    <asp:Literal ID="ltrProducts" runat="server">
    </asp:Literal>
</asp:Content>