<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.Master" AutoEventWireup="true" CodeBehind="Chart.aspx.cs" Inherits="DayBuyDay.Pages.Chart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/ChartPage.css" rel="stylesheet" />
    <asp:Literal ID="ltrChart" runat="server">
    </asp:Literal>
</asp:Content>
