using ConsoleApp;
using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            MainMenu.ShowMainMenu();
            MenuManager.SortingMenu();         
        }
    }
}
