using CA_NorthwindOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Interfaces
{
    public interface ICategory
    {
        //Category List
        List<Category> GetCategories();

        //Category Add
        string AddCategory(Category category);

        //Category Delete
        bool DeleteCategory(int id);

        //Category Update
        bool UpdateCategory(Category category);
    }
}
