using CA_NorthwindOOP.Abstracts;
using CA_NorthwindOOP.Interfaces;
using CA_NorthwindOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Concretes
{
    public class CategoryManager : BaseManager, ICategoryManager
    {

        public static List<Category> _categories = new List<Category>();

        public void CreateCategory()
        {
            Category category = new Category();


            category.Id = _categories.Count + 1;
            Console.WriteLine("Kategori Ad: ");
            category.CategoryName = Console.ReadLine();
            Console.WriteLine("Kategori Aciklama: ");
            category.Description = Console.ReadLine();
            

            _categories.Add(category);
            Console.WriteLine("Kategori Eklendi");
        }

        public void DeleteCategory()
        {
            GetAllCategories();

            try
            {
                Console.WriteLine("Kategori Id");
                int categoryId = GetIntegerValue();
                Category deleted = GetCategory(categoryId);

                if (deleted != null)
                {
                    _categories.Remove(deleted);
                    Console.WriteLine($"Kategori silme islemi basarili.");
                }
                else
                {
                    Console.WriteLine("\nGirilen Id ile iliskilendirilmis bir kategori bulunamadi.");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetAllCategories()
        {
            if(_categories.Count == 0)
            {
                Console.WriteLine("\nHenuz bir kategori eklenmedi");
            }
            else
            {
                foreach (Category category in _categories)
                {
                    Console.WriteLine(category);
                }
            }
            
        }

        public Category GetCategory(int id)
        {
            foreach (Category item in _categories)
            {
                if (item.Id == id)
                {
                    return item;

                }
            }

            return null;
        }

        public void UpdateCategory()
        {

            Console.WriteLine("Güncellemek istediğiniz kategorinin Id sini girin: \n");

            GetAllCategories();

            try
            {
                int categoryId = GetIntegerValue();
                Category updated = GetCategory(categoryId);

                if (updated != null)
                {
                    Category category = new Category();

                    Console.WriteLine("(Güncelleme) Kategori Ad:");
                    category.CategoryName = Console.ReadLine();

                    if (!string.IsNullOrEmpty(category.CategoryName))
                        updated.CategoryName = category.CategoryName;

                    Console.WriteLine("(Güncelleme) Kategori Aciklama:");
                    category.Description = Console.ReadLine();

                    if (!string.IsNullOrEmpty(category.Description))
                        updated.Description = category.Description;

                }
                else
                {
                    Console.WriteLine("Girilen Id ile iliskilendirilmis bir kategori bulunamadi.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private int GetIntegerValue()
        {
            int value = 0;

            while (true)
            {


                try
                {

                    value = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lutfen tamsayi bir deger girin.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

            return value;
        }
    }
}
