using CA_NorthwindOOP.Interfaces;
using CA_NorthwindOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Concretes
{
    public class ProductConcrete : IProduct
    {

        public static List<Product> products = new List<Product>();

        public string AddProduct(Product product)
        {
            products.Add(product);
            return "Urun Eklendi";
        }

        public bool DeleteProduct(int id)
        {


            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    products.Remove(product);
                    return true;
                }

            }
            return false;
        }

        public List<Product> GetProducts()
        {

            return products;
        }

        public bool UpdateProduct(Product updated)
        {
            foreach (Product product in products)
            {
                if (product.Id == updated.Id)
                {
                    product.CreatedDate = updated.CreatedDate;
                    product.ProductName = updated.ProductName;
                    product.UnitPrice = updated.UnitPrice;
                    product.Stock = updated.Stock;
                    
                    return true;
                }

            }
            return false;
        }
    }
}
