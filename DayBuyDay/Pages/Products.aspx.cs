using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DayBuyDay.Classes;
using DayBuyDay.DbModel;

namespace DayBuyDay.Pages
{
    public partial class Products : System.Web.UI.Page
    {
        public Product Product { get; set; }
        public Sepet Sepet { get; set; }
       


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetProducts();  //Ürünleri Ekrana getiren Fonksiyon
                AddtoChart();   //Ürünleri sepete ekler
            }

        }

        private void AddtoChart()
        {
         this.Sepet=(Sepet)Session["Sepet"];
        }

        private void GetProducts()
        {
            DB_ServiceReference.DbWebServiceClient dbWebServiceClient = new DB_ServiceReference.DbWebServiceClient();
            DB_ServiceReference.DbWebServiceProducts[] dbWebServiceProductsArray = dbWebServiceClient.GetProducts();

            for (int i = 0; i < dbWebServiceProductsArray.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var product in dbWebServiceProductsArray)
                {
                    sb.Append("<div class=\"product\">");
                    sb.AppendFormat("<div class=\"product-image\"><img src=\"{0}\"/></div> ", product.ImageUrl);
                    sb.AppendFormat("<div class=\"product-name\">{0}</div>", product.ProductName);
                    sb.AppendFormat("<div class=\"product-price\">{0}</div>", product.Price);
                    sb.AppendFormat("<div class=\"addtochart\"><input type=\"button\" ID=\"btnsepet\" onClick=\"location='Chart.aspx?Id={0}'\" runat=\"server\" value=\"Sepete Ekle\"/></div>", product.ProductId);
                    sb.AppendFormat("<div class=\"detail\"><input type=\"button\" onClick=\"location='Details.aspx?Id={0}'\" value=\"Detay\"/></div>", product.ProductId);
                    sb.Append("</div>");
                }
                
                ltrProducts.Text = sb.ToString();
            }
        }
    }
}