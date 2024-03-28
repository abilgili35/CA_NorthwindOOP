using CA_NorthwindOOP.Interfaces;
using CA_NorthwindOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Concretes
{
    public class CategoryConcrete : ICategory
    {

        public static List<Category> categories=new List<Category>();

        public string AddCategory(Category category)
        {
            categories.Add(category);
            return "Kategori Eklendi";
        }

        public bool DeleteCategory(int id)
        {


            foreach (Category category in categories)
            {
                if (category.Id == id)
                {
                    categories.Remove(category);
                    return true;
                }
                
            }
            return false;
        }

        public List<Category> GetCategories()
        {
            
            return categories;
        }

        public bool UpdateCategory(Category updated)
        {
            foreach (Category category in categories)
            {
                if (category.Id == updated.Id)
                {
                    category.CreatedDate = updated.CreatedDate;
                    category.CategoryName = updated.CategoryName;
                    category.Description = updated.Description;
                    return true;
                }

            }
            return false;
        }
    }
}
