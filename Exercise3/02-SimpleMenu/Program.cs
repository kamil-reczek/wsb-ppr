using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SimpleMenu
{
    class Program
    {
        enum MenuItems { NewGame = 1, Author = 2, Exit = 3}

        private static MenuItems GetUserAction(string msg)
        {
            int input = 0;
            while (true)
            {
                Console.Write(msg);
                if(int.TryParse(Console.ReadLine(), out input) && Enum.IsDefined(typeof(MenuItems), input)) {
                    return (MenuItems)input;
                } else
                {
                    Console.WriteLine("Try again! Select 1, 2 or 3");
                }
            }
        } 

        private static void DisplayManu()
        {
            Console.Clear();
            Console.WriteLine("--- SIMPLE MENU ---");
            Console.WriteLine();
            Console.WriteLine("[1] New game");
            Console.WriteLine("[2] Author");
            Console.WriteLine("[3] Exit");
            Console.WriteLine();
        }

        private static void NewGame()
        {
            Console.WriteLine("UNDER CONSTRUCTION !!!");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to Menu");
            Console.ReadKey();
        }

        private static void GetAuthor()
        {
            Console.WriteLine("Pan Krzysztof Jarzyna ze Szczecina");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to Menu");
            Console.ReadKey();
        }

        private static void MainLoop()
        {
            bool exit = false;
            while(!exit)
            {
                DisplayManu();
                switch(GetUserAction("Select: "))
                {
                    case MenuItems.NewGame:
                        NewGame();
                        break;
                    case MenuItems.Author:
                        GetAuthor();
                        break;
                    case MenuItems.Exit:
                        if(GetUserAction("Select 3 to confirm exit: ") == MenuItems.Exit)
                        {
                            exit = true;
                        }
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
