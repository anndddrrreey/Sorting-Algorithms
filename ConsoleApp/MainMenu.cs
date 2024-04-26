using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MainMenu
    {
        public static int[] flattenedArray = new int[0];

        public static void ShowMainMenu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - Ввести новий масив");
            Console.WriteLine("2 - Зчитати масив з файлу");
            Console.WriteLine("3 - Згенерувати рандомно масив");
            Console.WriteLine("4 - Завершити програму");

            Console.WriteLine("Вибір: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    flattenedArray = InputData.InputArray();
                    break;
                case 2:
                    flattenedArray = ReadData.ReadArrayFromFile();
                    break;
                case 3:
                    RandomData randomData = new RandomData();
                    flattenedArray = randomData.GenerateAndSetRandomArray();
                    MenuManager.SortingMenu();
                    break;
                case 4:
                    Console.WriteLine("До побачення!");
                    Console.ReadKey(true);
                    return;
                default:
                    Console.WriteLine("Виберіть одну з доступних опцій.");
                    break;
            }
            MenuManager.SortingMenu();
        }
    }
}
