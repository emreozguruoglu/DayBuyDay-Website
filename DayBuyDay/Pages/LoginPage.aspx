<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="DayBuyDay.Pages.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        #table {
            margin-top:100px;
            margin-left:20px;
        }
        #Panel1 {
             margin-top:200px;
             margin-left:450px;
        }
    </style>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="311px" Width="397px" BorderColor="#FF6600" BorderStyle="Double">
            <table id="table">
                <tr>
                    <td>
                    </td>
                    <td><asp:Label Text="HOSGELDINIZ" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Label ID="lblKullaniciAdi" Text="Kullanici Adi :" runat="server"></asp:Label></td>
                    <td></td>
                    <td><asp:TextBox ID="txtUsername" runat="server" Text="" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Label ID="lblPassword" Text="Parola :" runat="server"></asp:Label></td>
                    <td></td>
                    <td><asp:TextBox ID="txtPassword" runat="server" Text=""></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td><asp:Button ID="btnAgree" runat="server" Text="GIRIS" OnClick="btnAgree_Click" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td><a href="Homepage.aspx" target="_blank">Misafir Olarak Giriş</a></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td><asp:Label ID="lblError" runat="server"></asp:Label></td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
