using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductsClient
{
    public partial class ProductsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetProducts_Button_Click(object sender, EventArgs e)
        {
            DB_ServiceReference.DbWebServiceClient dbWebServiceClient = new DB_ServiceReference.DbWebServiceClient();
            DB_ServiceReference.DbWebServiceProducts[] dbWebServiceProductsArray= dbWebServiceClient.GetProducts();

            for (int i = 0; i < dbWebServiceProductsArray.Length; i++)
            {

            }
        }
    }
}