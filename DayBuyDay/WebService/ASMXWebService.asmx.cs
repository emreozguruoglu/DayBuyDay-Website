using DayBuyDay.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace DayBuyDay.WebService
{
    /// <summary>
    /// Summary description for ASMXWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ASMXWebService : System.Web.Services.WebService
    {

        public class Products
        {
            public int ProductId;
            public int CategoryId;
            public string ProductName;
            public string ImageUrl;
            public string Description;
            public string Price;
            public char Status;

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Products[] GetProducts()
        {
            DbModel.ProductDbEntities Entities = new DbModel.ProductDbEntities();

            var products = (from a in Entities.Product
                            select new
                            {
                                a.ProductId,
                                a.ImageUrl,
                                a.ProductName,
                                a.Price,
                            }).ToArray();

            Products[] productsArray = new Products[products.Length];
            Products product;

            if (products != null)
                for (int i = 0; i < products.Length; i++)
                {
                    product = new Products();
                    product.ImageUrl = products[i].ImageUrl;
                    product.Price = products[i].Price;
                    product.ProductId = products[i].ProductId;
                    product.ProductName = products[i].ProductName;
                    product.ImageUrl = products[i].ImageUrl;

                    productsArray[i] = product;
                }
            return productsArray;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SendProducts(Product product)
        {
            DbModel.ProductDbEntities Entities = new DbModel.ProductDbEntities();

            Entities.Product.Add(product);
            Entities.SaveChanges();
        }
    }
}
