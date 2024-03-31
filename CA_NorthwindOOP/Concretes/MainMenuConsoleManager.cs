using CA_NorthwindOOP.Enums;
using CA_NorthwindOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CA_NorthwindOOP.Concretes.MainMenuConsoleManager;

namespace CA_NorthwindOOP.Concretes
{
    public class MainMenuConsoleManager:IConsoleManager
    {
        public MainMenuConsoleManager(string[] menuList, string menuName, SubMenuConsoleManager[] submenus) 
        {
            MenuList = menuList;
            MenuName = menuName;
            Submenus = submenus;
        }

        public string[] MenuList { get; set; }
        public string MenuName { get; set; }
        public SubMenuConsoleManager[] Submenus { get; set; }

        //string[] menu = { "1-Öğrenci Listele", "2-Öğrenci Ekle", "3-Öğrenci Güncelle", "4-Öğrenci Sil" };
        public void GetConsoleMenu()
        {
            //Console.WriteLine("Öğrenci işlerine Hoşgeldiniz! Aşağıdan işlem seçin");
            Console.Clear();
            Console.WriteLine($"-------------------- {MenuName.ToUpper()} --------------------\n");

            for (int i = 0; i < MenuList.Length; i++)
            {
                Console.WriteLine($"{i+1}-{MenuList[i]}");
            }

            Console.WriteLine($"{MenuList.Length+1}-Cikis");

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

                if ( selected == -1 ) 
                {
                    Console.WriteLine("Bir hata olustu.Lutfen tamsayi bir deger girin.");
                    Console.WriteLine("Devam etmek icin enter tusuna basin.");
                    Console.ReadLine();
                }
                else if(selected == MenuList.Length + 1)
                {
                    break;
                }
                else
                {
                    MenuAction menuAction = (MenuAction)selected;

                    switch (menuAction)
                    {
                        case MenuAction.List:
                            Submenus[(int)MenuAction.List - 1].RunConsoleManager();
                            //Console.WriteLine("List");
                            //studentManager.GetAllStudents();
                            break;
                        case MenuAction.Create:
                            Submenus[(int)MenuAction.Create - 1].RunConsoleManager();
                            //Console.WriteLine("Create");
                            //studentManager.CreateStudent();
                            break;
                        case MenuAction.Update:
                            Submenus[(int)MenuAction.Update - 1].RunConsoleManager();
                            //Console.WriteLine("Update");
                            //studentManager.UpdateStudent();
                            break;
                        case MenuAction.Delete:
                            Submenus[(int)MenuAction.Delete - 1].RunConsoleManager();
                            //Console.WriteLine("Delete");
                            //studentManager.DeleteStudent();
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
