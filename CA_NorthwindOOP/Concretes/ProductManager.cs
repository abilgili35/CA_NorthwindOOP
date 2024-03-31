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
    public class ProductManager : BaseManager,  IProductManager
    {

        public static List<Product> _products = new List<Product>();

        
        public void CreateProduct()
        {
            
            Product product = new Product();
            

            product.Id = _products.Count + 1;
            Console.WriteLine("Urun Ad: ");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Urun Birim Fiyat: ");
            product.UnitPrice = GetDecimalValue();
            Console.WriteLine("Urun Stok Adedi: ");
            product.Stock = GetIntegerValue();

            _products.Add(product);
            Console.WriteLine("Urun Eklendi");
        }

        public void DeleteProduct()
        {
            GetAllProducts();

            try
            {
                Console.WriteLine("Urun Id");
                int productId = GetIntegerValue();
                Product deleted = GetProduct(productId);
                
                if (deleted != null)
                {
                    _products.Remove(deleted);
                    Console.WriteLine("Urun silme islemi basarili.");
                }
                else
                {
                    Console.WriteLine("Girilen Id ile iliskilendirilmis bir urun bulunamadi.");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            
        }

        public void GetAllProducts()
        {
            if(_products.Count == 0)
            {
                Console.WriteLine("\nHenuz bir urun eklenmedi.\n");
            }
            else
            {
                foreach (Product product in _products)
                {
                    Console.WriteLine(product);
                }
            }

            
            
        }

        public Product GetProduct(int id)
        {
            
            foreach (Product item in _products)
            {
                if (item.Id == id)
                {
                    return item;

                }
            }
            
            return null;
        }

        

        public void UpdateProduct()
        {
            
            Console.WriteLine("Güncellemek istediğiniz urunun Id sini girin: \n");

            GetAllProducts();

            try
            {
                int productId = GetIntegerValue();
                Product updated = GetProduct(productId);

                if (updated != null)
                {
                    Product product = new Product();

                    Console.WriteLine("(Güncelleme) Urun Ad:");
                    product.ProductName = Console.ReadLine();

                    if (!string.IsNullOrEmpty(product.ProductName))
                        updated.ProductName = product.ProductName;

                    Console.WriteLine("(Güncelleme) Urun Birim Fiyat:");
                    product.UnitPrice = GetDecimalValue();

                    if (!(product.UnitPrice <= 0))
                        updated.UnitPrice = product.UnitPrice;

                    Console.WriteLine("(Güncelleme) Urun Stok Adedi:");
                    product.Stock = GetIntegerValue();

                    if (!(product.Stock <= 0))
                        updated.Stock = product.Stock;

                }
                else
                {
                    Console.WriteLine("Girilen Id ile iliskilendirilmis bir urun bulunamadi.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            
        }

        private decimal GetDecimalValue()
        {
            decimal value = 0M;

            while (true)
            {
                try
                {

                    value = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lutfen decimal bir deger girin.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

            return value;
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
