using CA_NorthwindOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Interfaces
{
    public interface ICategoryManager
    {
        void GetAllCategories();
        Category GetCategory(int id);
        void CreateCategory();

        //Category Delete
        void DeleteCategory();

        //Category Update
        void UpdateCategory();
    }
}
