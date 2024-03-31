using CA_NorthwindOOP.Abstracts;
using CA_NorthwindOOP.Concretes;
using CA_NorthwindOOP.Enums;
using CA_NorthwindOOP.Models;

namespace CA_NorthwindOOP
{
    class Program
    {

        

        public static void Main(string[] args)
        {


            #region main
            string[] mainMenuList = { "Listele", "Ekle", "Güncelle", "Sil" };
            string[] addMenuList = { "Urun Ekle", "Kategori Ekle" };
            string[] updateMenuList = { "Urun Guncelle", "Kategori Guncelle" };
            string[] deleteMenuList = { "Urun Sil", "Kategori Sil" };
            string[] listMenuList = { "Urun Listele", "Kategori Listele" };

            BaseManager[] managers = new BaseManager[2];

            ProductManager productManager = new ProductManager();
            CategoryManager categoryManager = new CategoryManager();

            managers[(int)SubMenuAction.Product - 1] = productManager;
            managers[(int)SubMenuAction.Category - 1] = categoryManager;

            SubMenuConsoleManager addMenu = new SubMenuConsoleManager(addMenuList, "Ekle", MenuAction.Create, managers);
            SubMenuConsoleManager updateMenu = new SubMenuConsoleManager(updateMenuList, "Guncelle", MenuAction.Update, managers);
            SubMenuConsoleManager deleteMenu = new SubMenuConsoleManager(deleteMenuList, "Sil", MenuAction.Delete, managers);
            SubMenuConsoleManager listMenu = new SubMenuConsoleManager(listMenuList, "Listele", MenuAction.List, managers);

            SubMenuConsoleManager[] submenus = new SubMenuConsoleManager[4];
            submenus[(int)MenuAction.List - 1] = listMenu;
            submenus[(int)MenuAction.Create - 1] = addMenu;
            submenus[(int)MenuAction.Update - 1] = updateMenu;
            submenus[(int)MenuAction.Delete - 1] = deleteMenu;


            MainMenuConsoleManager mainMenu = new MainMenuConsoleManager(mainMenuList, "Ana Menu", submenus);

            mainMenu.RunConsoleManager();
            #endregion

            #region ProductManager Test
            //ProductManager productManager = new ProductManager();

            //productManager.CreateProduct();
            //productManager.GetAllProducts();
            //productManager.CreateProduct();
            //productManager.GetAllProducts();
            //productManager.CreateProduct();
            //productManager.GetAllProducts();
            //productManager.UpdateProduct();
            //productManager.GetAllProducts();
            //productManager.DeleteProduct();
            //productManager.GetAllProducts(); 
            #endregion

            #region CategoryManager Test
            //CategoryManager categoryManager = new CategoryManager();

            //categoryManager.CreateCategory();
            //categoryManager.GetAllCategories();
            //categoryManager.CreateCategory();
            //categoryManager.GetAllCategories();
            //categoryManager.CreateCategory();
            //categoryManager.GetAllCategories();
            //categoryManager.UpdateCategory();
            //categoryManager.GetAllCategories();
            //categoryManager.DeleteCategory();
            //categoryManager.GetAllCategories(); 
            #endregion

            Console.WriteLine("\nProgram sonlandirildi.");
            Console.ReadLine();
            


        }

        static string GetStringValue()
        {
            string value = "";

            while (true)
            {


                try
                {

                    value = Console.ReadLine();
                    if (value == "")
                    {
                        Console.WriteLine("Bos bir deger girdiniz.Lutfen tekrar deneyiniz.");
                        continue;
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

            return value;
        }

        static decimal GetDecimalValue()
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

        

        static int GetIntegerValue()
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

        //static void ListMenu()
        //{
        //    int choice = 0;
            

        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Clear();
        //            Console.WriteLine("1-Urun Listele\n2-Kategori Listele\n3-Cikis");
        //            Console.Write("Sec:");
        //            choice = GetIntegerValue();

        //            if (choice == 1)
        //            {
        //                Console.WriteLine("-------------------- URUNLER -----------------------");

        //                foreach(Product p in productConcrete.GetProducts())
        //                {
        //                    Console.WriteLine(p);
        //                }


        //                Console.ReadLine();



        //            }
        //            else if (choice == 2)
        //            {
        //                Console.WriteLine("-------------------- KATEGORILER -----------------------");

        //                foreach (Category c in categoryConcrete.GetCategories())
        //                {
        //                    Console.WriteLine(c);
        //                }

        //                Console.ReadLine();
        //            }
        //            else if (choice == 3)
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Yanlis bir secim yaptiniz.Tekrar deneyiniz.");
        //                Console.ReadLine();
        //                continue;
        //            }


        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Lutfen tamsayi bir deger girin.");
        //            Console.ReadLine();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.ToString());
        //            Console.ReadLine();
        //        }



        //    }
        //}

        //static void AddMenu()
        //{
        //    int choice = 0;
        //    int productId = 0;
        //    string productName = "";
        //    decimal unitPrice = 0;
        //    int stock = 0;
        //    int categoryId = 0;
        //    string categoryName = "";
        //    string description = "";

        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Clear();
        //            Console.WriteLine("1-Urun Ekle\n2-Kategori Ekle\n3-Cikis");
        //            Console.Write("Sec:");
        //            choice = GetIntegerValue();

        //            if (choice == 1)
        //            {
        //                Console.WriteLine("Lutfen eklemek istediginiz urunun Id sini giriniz.");
        //                productId = GetIntegerValue();
        //                Console.WriteLine("Lutfen eklemek istediginiz urunun Urun Adini giriniz.");
        //                productName = GetStringValue();
        //                Console.WriteLine("Lutfen eklemek istediginiz urunun Birim Fiyatini giriniz.");
        //                unitPrice = GetDecimalValue();
        //                Console.WriteLine("Lutfen eklemek istediginiz urunun Stok Miktarini giriniz.");
        //                stock = GetIntegerValue();

        //                productConcrete.AddProduct(new Product()
        //                    {
        //                        Id = productId,
        //                        ProductName = productName,
        //                        UnitPrice = unitPrice,
        //                        Stock = stock
        //                    }
        //                );

        //                Console.WriteLine("Urun ekleme islemi basarili.");
        //                Console.ReadLine();


        //            }
        //            else if (choice == 2)
        //            {
        //                Console.WriteLine("Lutfen eklemek istediginiz kategorinin Id sini giriniz.");
        //                categoryId = GetIntegerValue();
        //                Console.WriteLine("Lutfen eklemek istediginiz kategorinin Kategori Adini giriniz.");
        //                categoryName = GetStringValue();
        //                Console.WriteLine("Lutfen eklemek istediginiz kategorinin Aciklama bilgisini giriniz.");
        //                description = GetStringValue();
                        

        //                categoryConcrete.AddCategory(new Category()
        //                {
        //                    Id = categoryId,
        //                    CategoryName = categoryName,
        //                    Description = description
        //                }
        //                );

        //                Console.WriteLine("Kategori ekleme islemi basarili.");

        //                Console.ReadLine();
        //            }
        //            else if (choice == 3)
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Yanlis bir secim yaptiniz.Tekrar deneyiniz.");
        //                Console.ReadLine();
        //                continue;
        //            }


        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Lutfen tamsayi bir deger girin.");
        //            Console.ReadLine();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.ToString());
        //            Console.ReadLine();
        //        }



        //    }
        //}

        //static void UpdateMenu()
        //{
        //    int choice = 0;
        //    int productId = 0;
        //    string productName = "";
        //    decimal unitPrice = 0;
        //    int stock = 0;
        //    int categoryId = 0;
        //    string categoryName = "";
        //    string description = "";

        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Clear();
        //            Console.WriteLine("1-Urun Guncelle\n2-Kategori Guncelle\n3-Cikis");
        //            Console.Write("Sec:");
        //            choice = GetIntegerValue();

        //            if (choice == 1)
        //            {
        //                Console.WriteLine("-------------------- URUNLER -----------------------");

        //                foreach (Product p in productConcrete.GetProducts())
        //                {
        //                    Console.WriteLine(p);
        //                }


        //                Console.WriteLine();

        //                Console.WriteLine("Lutfen guncellemek istediginiz urunun Id sini giriniz.");
        //                productId = GetIntegerValue();
        //                Console.WriteLine("Lutfen guncellemek istediginiz urunun Urun Adini giriniz.");
        //                productName = GetStringValue();
        //                Console.WriteLine("Lutfen guncellemek istediginiz urunun Birim Fiyatini giriniz.");
        //                unitPrice = GetDecimalValue();
        //                Console.WriteLine("Lutfen guncellemek istediginiz urunun Stok Miktarini giriniz.");
        //                stock = GetIntegerValue();

        //                bool isUpdated = productConcrete.UpdateProduct(new Product()
        //                {
        //                    Id = productId,
        //                    ProductName = productName,
        //                    UnitPrice = unitPrice,
        //                    Stock = stock
        //                }
        //                );

        //                if( isUpdated)
        //                {
        //                    Console.WriteLine("Urun guncelleme islemi basarili.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Urun guncelleme islemi basarisiz.");
        //                }

                        
        //                Console.ReadLine();


        //            }
        //            else if (choice == 2)
        //            {
        //                Console.WriteLine("-------------------- KATEGORILER -----------------------");

        //                foreach (Category c in categoryConcrete.GetCategories())
        //                {
        //                    Console.WriteLine(c);
        //                }


        //                Console.WriteLine("Lutfen guncellemek istediginiz kategorinin Id sini giriniz.");
        //                categoryId = GetIntegerValue();
        //                Console.WriteLine("Lutfen guncellemek istediginiz kategorinin Kategori Adini giriniz.");
        //                categoryName = GetStringValue();
        //                Console.WriteLine("Lutfen guncellemek istediginiz kategorinin Aciklama bilgisini giriniz.");
        //                description = GetStringValue();


        //                bool isUpdated = categoryConcrete.UpdateCategory(new Category()
        //                {
        //                    Id = categoryId,
        //                    CategoryName = categoryName,
        //                    Description = description
        //                }
        //                );

        //                if(isUpdated)
        //                {
        //                    Console.WriteLine("Kategori guncelleme islemi basarili.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Kategori guncelleme islemi basarisiz.");
        //                }
                        

        //                Console.ReadLine();
        //            }
        //            else if (choice == 3)
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Yanlis bir secim yaptiniz.Tekrar deneyiniz.");
        //                Console.ReadLine();
        //                continue;
        //            }


        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Lutfen tamsayi bir deger girin.");
        //            Console.ReadLine();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.ToString());
        //            Console.ReadLine();
        //        }



        //    }
        //}

        //static void DeleteMenu()
        //{
        //    int choice = 0;
        //    int productId = 0;
        //    int categoryId = 0;
            
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Clear();
        //            Console.WriteLine("1-Urun Sil\n2-Kategori Sil\n3-Cikis");
        //            Console.Write("Sec:");
        //            choice = GetIntegerValue();

        //            if (choice == 1)
        //            {
        //                Console.WriteLine("-------------------- URUNLER -----------------------");

        //                foreach (Product p in productConcrete.GetProducts())
        //                {
        //                    Console.WriteLine(p);
        //                }


        //                Console.WriteLine();

        //                Console.WriteLine("Lutfen silmek istediginiz urunun Id sini giriniz.");
        //                productId = GetIntegerValue();
                       

        //                bool isDeleted = productConcrete.DeleteProduct(productId);

        //                if (isDeleted)
        //                {
        //                    Console.WriteLine("Urun silme islemi basarili.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Urun silme islemi basarisiz.");
        //                }


        //                Console.ReadLine();


        //            }
        //            else if (choice == 2)
        //            {
        //                Console.WriteLine("-------------------- KATEGORILER -----------------------");

        //                foreach (Category c in categoryConcrete.GetCategories())
        //                {
        //                    Console.WriteLine(c);
        //                }


        //                Console.WriteLine("Lutfen silmek istediginiz kategorinin Id sini giriniz.");
        //                categoryId = GetIntegerValue();
                        


        //                bool isDeleted = categoryConcrete.DeleteCategory(categoryId);

        //                if (isDeleted)
        //                {
        //                    Console.WriteLine("Kategori silme islemi basarili.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Kategori silme islemi basarisiz.");
        //                }


        //                Console.ReadLine();
        //            }
        //            else if (choice == 3)
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Yanlis bir secim yaptiniz.Tekrar deneyiniz.");
        //                Console.ReadLine();
        //                continue;
        //            }


        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Lutfen tamsayi bir deger girin.");
        //            Console.ReadLine();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.ToString());
        //            Console.ReadLine();
        //        }



        //    }
        //}

        //static void MainMenu()
        //{

            

        //    int choice = 0;

        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Clear();
        //            Console.WriteLine("1-Ekle\n2-Guncelle\n3-Sil\n4-Listele\n5-Cikis");
        //            Console.Write("Sec:");
        //            choice = GetIntegerValue();

        //            if (choice == 1)
        //            {
        //                AddMenu();
        //            }
        //            else if (choice == 2)
        //            {
        //                UpdateMenu();
        //            }
        //            else if (choice == 3)
        //            {
        //                DeleteMenu();
        //            }
        //            else if (choice == 4)
        //            {
        //                ListMenu();
        //            }
        //            else if (choice == 5)
        //            {
        //                return;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Yanlis bir secim yaptiniz.Tekrar deneyiniz.");
        //                Console.ReadLine();
        //                continue;
        //            }


        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Lutfen tamsayi bir deger girin.");
        //            Console.ReadLine();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.ToString());
        //            Console.ReadLine();
        //        }



        //    }
        //}
    }
}