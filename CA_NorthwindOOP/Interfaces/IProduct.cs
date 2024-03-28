using System;
using CA_NorthwindOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Interfaces
{
    public interface IProduct
    {
        //Category List
        List<Product> GetProducts();

        //Category Add
        string AddProduct(Product product);

        //Category Delete
        bool DeleteProduct(int id);

        //Category Update
        bool UpdateProduct(Product product);
    }
}