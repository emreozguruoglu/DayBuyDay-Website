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
    public partial class Details : System.Web.UI.Page
    {
        public Product Product { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowDetails();
            }
        }

        private void ShowDetails()
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            DbModel.ProductDbEntities Entities = new DbModel.ProductDbEntities();

            this.Product = Entities.Product.Where(x => x.ProductId == id).FirstOrDefault();

            if (this.Product != null)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<div class=\"product\">");
                sb.AppendFormat("<div class=\"product-image\"><img src=\"{0}\"/></div> ", this.Product.ImageUrl);
                sb.AppendFormat("<div class=\"product-id\">{0}</div> ", this.Product.ProductId);
                sb.AppendFormat("<div class=\"product-name\">{0}</div>", this.Product.ProductName);
                sb.AppendFormat("<div class=\"product-price\">{0}</div>", this.Product.Price);
                sb.AppendFormat("<div class=\"product-description\">{0}</div>", this.Product.Description);
                sb.AppendFormat("<div class=\"addtochart\"><input type=\"button\" onClick=\"location='Chart.aspx?Id={0}'\" value=\"Sepete Ekle\"/></div>", this.Product.ProductId);
                sb.Append("</div>");

                ltrShowDetail.Text = sb.ToString();
            }
        }
    }
}