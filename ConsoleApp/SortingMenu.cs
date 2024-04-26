using System;
using Interfaces;
using SortingAlgorithms;

namespace ConsoleApp
{
    public class MenuManager
    {
        public static int[] flattenedArray = new int[0];

        public static void SortingMenu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - Ввести новий масив");
            Console.WriteLine("2 - Зчитати масив з файлу");
            Console.WriteLine("3 - Згенерувати рандомно масив");
            Console.WriteLine("4 - Відсортувати методом бульбашки");
            Console.WriteLine("5 - Відсортувати методом вставки");
            Console.WriteLine("6 - Відсортувати методом вибору");
            Console.WriteLine("7 - Відсортувати методом швидкого сортування");
            Console.WriteLine("8 - Завершити програму");

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
                    break;
                case 4:
                    SortArray(new BubbleSorter());
                    break;
                case 5:
                    SortArray(new InsertionSorter());
                    break;
                case 6:
                    SortArray(new SelectionSorter());
                    break;
                case 7:
                    SortArray(new QuickSorter());
                    break;
                case 8:
                    Console.WriteLine("До побачення!");
                    Console.ReadKey(true);
                    break;
                default:
                    Console.WriteLine("Виберіть одну опцію серед наведених");
                    break;
            }
            SortingMenu();
        }

        public static void SortArray(ISorter sorter)
        {
            if (MenuManager.flattenedArray.Length > 0)
            {
                Console.WriteLine($"\nСортування за допомогою {sorter.GetType().Name}:");
                int[] sortedArray = (int[])MenuManager.flattenedArray.Clone();
                sorter.Sort(sortedArray);
                PrintArray(sortedArray);
            }
            else
            {
                Console.WriteLine("Ви не ввели масив. Спробуйте повторно ввести.");
                InputData.InputArray();
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
