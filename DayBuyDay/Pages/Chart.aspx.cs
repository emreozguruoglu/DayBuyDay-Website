using DayBuyDay.Classes;
using DayBuyDay.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DayBuyDay.Pages
{
    public partial class Chart : System.Web.UI.Page
    {
        public Product Product { get; set; } /*Databasedeki ürünler için ürün tipinde ürünler oluşturduk.*/
        public Sepet Sepet { get; set; } /*Bir sepet oluşturduk...*/

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack){ /*Sayfada her işlem yapıldığında verilerin sunucuya 
                                   * tek tek yerine bir kerede gönderilmesi için
                                   * bu adımı yapıyoruz. */

                ShowChart(); //Bu fonksiyon ile sepeti gösteriyoruz...
            }
        }

        private void ShowChart()
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]); //Id'yi querystring ile yolluyoruz.

            DbModel.ProductDbEntities Entities = new DbModel.ProductDbEntities(); //Yeni bir Entity oluşturduk.

            this.Product = Entities.Product.Where(x => x.ProductId == id).FirstOrDefault(); /* "x=>" Entity Framework'e özgü 
                                                                                             * Lambda Expression kullanımı*/
                                                                                             
            if (Session["Sepet"] == null) // Session bos mu kontrolü yapılıyor
            {
                this.Sepet = new Sepet();
                this.Sepet.Products = new List<Product>();
                this.Sepet.Products.Add(this.Product);
                Session["Sepet"] = this.Sepet;
            }
            else   //   Session bos değilse kontrolü yapılıyor
            {
                this.Sepet = (Sepet)Session["Sepet"];
                this.Sepet.Products.Add(this.Product);
                Session["Sepet"] = this.Sepet;
            }
            
            if (this.Sepet != null && this.Sepet.Products != null) //O an ki sepet durumu ve sepetteki ürünlerin kontrolü
            {
                StringBuilder sb = new StringBuilder(); /*Literalde bir şey göstermek istedğimizide oluşturmamız gereklidir.
                                                         * using System.Text;'i unutma yoksa çalışmaz...! */

                foreach (var product in this.Sepet.Products) /*Her eklenen ürünü ekrana yazdırmak için kullanıldı...*/
                {
                    /*Ekranda SB ile bir veri göstermek... */
                    sb.Append("<div class=\"product\">");
                    sb.AppendFormat("<div class=\"product-image\"><img src=\"{0}\"/></div> ", product.ImageUrl); 
                    sb.AppendFormat("<div class=\"product-name\">{0}</div>", product.ProductName);
                    sb.AppendFormat("<div class=\"product-price\">{0}</div>", product.Price);
                    sb.AppendFormat("<div class=\"product-description\">{0}</div>", product.Status);
                    //sb.AppendFormat("<div class=\"DeleteProduct\"><input type=\"button\" onClick=\"location='Products.aspx'\" value=\"Çıkar\"/></div>");
                    sb.AppendFormat("</div>");
                }
                sb.Append("<br></br>");
                sb.Append("<br></br>");
                sb.Append("<br></br>");
                sb.Append("<br></br>");
                sb.Append("<br></br>");

                sb.AppendFormat("<div class=\"detail\"><input type=\"button\" onClick=\"location='Products.aspx'\" value=\"GERİ\"/></div>");
                
                ltrChart.Text = sb.ToString(); //Ekrana Ürünleri Literal yardımıyla yazdırdık.
            }
        }
    }
}
