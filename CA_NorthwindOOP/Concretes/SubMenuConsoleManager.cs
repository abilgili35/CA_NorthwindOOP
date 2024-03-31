using CA_NorthwindOOP.Abstracts;
using CA_NorthwindOOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Concretes
{
    public class SubMenuConsoleManager
    {
        public SubMenuConsoleManager(string[] subMenuList, string subMenuName, MenuAction parentMenuAction, BaseManager[] managers)
        {
            SubMenuList = subMenuList;
            SubMenuName = subMenuName;
            ParentMenuAction = parentMenuAction;
            Managers = managers;
        }

        public string[] SubMenuList { get; set; }
        public string SubMenuName { get; set; }
        public MenuAction ParentMenuAction { get; set; }
        public BaseManager[] Managers { get; set; }


        //string[] menu = { "1-Öğrenci Listele", "2-Öğrenci Ekle", "3-Öğrenci Güncelle", "4-Öğrenci Sil" };
        public void GetConsoleMenu()
        {
            //Console.WriteLine("Öğrenci işlerine Hoşgeldiniz! Aşağıdan işlem seçin");
            Console.Clear();
            Console.WriteLine($"-------------------- {SubMenuName.ToUpper()} --------------------\n");

            for (int i = 0; i < SubMenuList.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{SubMenuList[i]}");
            }

            Console.WriteLine($"{SubMenuList.Length + 1}-Cikis");

        }

        public int SelectConsoleMenu()
        {
            try
            {
                Console.WriteLine("Seç: ");
                int selected = int.Parse(Console.ReadLine());
                return selected;

            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public void RunConsoleManager()
        {
            while (true)
            {
                GetConsoleMenu();
                int selected = SelectConsoleMenu();

                if (selected == -1)
                {
                    Console.WriteLine("Bir hata olustu.Lutfen tamsayi bir deger girin.");
                    Console.WriteLine("Devam etmek icin enter tusuna basin.");
                    Console.ReadLine();
                }
                else if (selected == SubMenuList.Length + 1)
                {
                    break;
                }
                else
                {
                    SubMenuAction subMenuAction = (SubMenuAction)selected;

                    switch (subMenuAction)
                    {
                        case SubMenuAction.Product:

                            ProductManager productManager = (ProductManager)Managers[(int)SubMenuAction.Product - 1];

                            switch (ParentMenuAction)
                            {
                                case MenuAction.List:
                                    Console.WriteLine("-------------------- Urun Listeleme --------------------");
                                    productManager.GetAllProducts();
                                    break;
                                case MenuAction.Update:
                                    Console.WriteLine("-------------------- Urun Guncelleme --------------------");
                                    productManager.UpdateProduct();
                                    break;
                                case MenuAction.Delete:
                                    Console.WriteLine("-------------------- Urun Silme --------------------");
                                    productManager.DeleteProduct();
                                    break;
                                case MenuAction.Create:
                                    Console.WriteLine("-------------------- Urun Ekleme --------------------");
                                    productManager.CreateProduct();
                                    break;
                                default:
                                    Console.WriteLine("Bir hata olustu.");
                                    break;
                            }

                            break;
                        case SubMenuAction.Category:

                            CategoryManager category = (CategoryManager)Managers[(int)SubMenuAction.Category - 1];
                            
                            switch (ParentMenuAction)
                            {
                                case MenuAction.List:
                                    Console.WriteLine("-------------------- Kategori Listeleme --------------------");
                                    category.GetAllCategories();
                                    break;
                                case MenuAction.Update:
                                    Console.WriteLine("-------------------- Kategori Guncelleme --------------------");
                                    category.UpdateCategory();
                                    break;
                                case MenuAction.Delete:
                                    Console.WriteLine("-------------------- Kategori Silme --------------------");
                                    category.DeleteCategory();
                                    break;
                                case MenuAction.Create:
                                    Console.WriteLine("-------------------- Kategori Ekleme --------------------");
                                    category.CreateCategory();
                                    break;
                                default:
                                    Console.WriteLine("Bir hata olustu.");
                                    break;
                            }

                            break;
                        default:
                            Console.WriteLine("Yanlis bir secim yaptiniz.");
                            break;
                    }

                    Console.WriteLine("\nDevam etmek icin enter tusuna basin.");
                    Console.ReadLine();
                }



            }
        }
    }
}
