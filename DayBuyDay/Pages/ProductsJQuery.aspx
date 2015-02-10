<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductsJQuery.aspx.cs" Inherits="DayBuyDay.Pages.ProductsJQuery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="/Scripts/jquery-1.11.1.js"></script>
    <script src="/Scripts/jquery-1.11.1.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $.ajax({
                type: "POST",
                data: "", //Data boş olmak zorunda
                dataType: "json",
                url: "/WebService/ASMXWebService.asmx/GetProducts",
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    var sb = "";
                    var ProductTable = document.createElement("table");//Bir tablo yarattık
                    var img;
                    // TABLE'ın CSS'ine bu şekilde erişilebilir.
                    //ProductTable.style. = "";

                    //ProductTable.className = "ProductTableClass"; ya da bu şekilde link eklermiş gibi...
                    //ProductTableClass adında bir şey yarat
                    for (var i = 0; i < data.d.length; i++) {
                        img = document.createElement('img'); //Bütün imageler için tek tek oluşturulması lazım.
                        img.setAttribute("src", data.d[i].ImageUrl);//SRC'sini img'nin src'sine atadık
                        img.setAttribute("width", "210px");
                        img.setAttribute("height", " 300px");
                        img.setAttribute("border", "1px solid #0094ff;");

                        //---------ATAMA İŞLEMLERİ--------------//
                        sb += data.d[i].ImageUrl;
                        sb += data.d[i].ProductId;
                        sb += data.d[i].ProductName;
                        sb += data.d[i].Price;
                        //----------------------------------------//

                        //----------------------------------------//
                        var ProductTR = document.createElement("tr");//Döngü her buraya geldiğinde değerleri yeni satıra atasın diye yazdık.
                        var td = document.createElement("td");//Satır için yeni bir sütun yarattık
                        td.appendChild(img);//İmage i ekledik
                        ProductTR.appendChild(td); //Sütuna değerleri ekledik
                        
                        //----------------------------------------//
                        td = document.createElement("td");//Satır için yeni bir sütun yarattık
                        td.appendChild(document.createTextNode(data.d[i].ProductId));//ProductID'i ekledik
                        ProductTR.appendChild(td);//Sütuna değerleri ekledik
                        //----------------------------------------//

                        //----------------------------------------//
                        td = document.createElement("td");//Satır için yeni bir sütun yarattık
                        td.appendChild(document.createTextNode(data.d[i].ProductName));//ProductName'i ekledik
                        ProductTR.appendChild(td);//Sütuna değerleri ekledik
                        //----------------------------------------//

                        //----------------------------------------//
                        td = document.createElement("td");//Satır için yeni bir sütun yarattık
                        td.appendChild(document.createTextNode(data.d[i].Price));//Price'ı ekledik
                        ProductTR.appendChild(td);//Sütuna değerleri ekledik
                        //----------------------------------------//

                        ProductTable.appendChild(ProductTR);//Satırımıza değerlerimizi ekledik
                    }
                    divProducts.appendChild(ProductTable);//Tablomuzu div katmanına ekledik
                }
            });
        });

    </script>
    <div id="divProducts">
    </div>
</asp:Content>
