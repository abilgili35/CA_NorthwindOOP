using System;
using CA_NorthwindOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Interfaces
{
    public interface IProductManager
    {
        //Category List
        void GetAllProducts();
        Product GetProduct(int id);
        void CreateProduct();

        //Category Delete
        void DeleteProduct();

        //Category Update
        void UpdateProduct();
    }
}