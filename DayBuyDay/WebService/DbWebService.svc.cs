using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DayBuyDay.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DbWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DbWebService.svc or DbWebService.svc.cs at the Solution Explorer and start debugging.
    public class DbWebService : IDbWebService
    {
        [DataContract]
        public class Products
        {
            [DataMember]
            public int ProductId;

            [DataMember]
            public string ProductName;

            [DataMember]
            public string ImageUrl;

            [DataMember]
            public string Price;

        }


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
    }
}
