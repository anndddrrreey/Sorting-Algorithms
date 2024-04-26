using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class InputData
    {
        public static int[] flattenedArray = new int[0];
        public static int[] InputArray()
        {
            Console.WriteLine("Введіть розмір масиву (рядки x стовпці):");
            Console.Write("Рядки: ");
            int rows;
            while (true)
            {
                try
                {
                    rows = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введіть ціле число");
                    Console.Write("Рядки: ");
                    continue;
                }
            }

            Console.Write("Стовпці: ");
            int cols;
            while (true)
            {
                try
                {
                    cols = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введіть ціле число");
                    Console.Write("Стовпці: ");
                    continue;
                }
            }

            int[,] array = new int[rows, cols];

            Console.WriteLine("Введіть елементи масиву:");

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Рядок [{i + 1}]: ");
                for (int j = 0; j < cols; j++)
                {

                    array[i, j] = int.Parse(Console.ReadLine());

                }
            }

            // Виведення двовимірного масиву
            Console.WriteLine("\nВведений двовимірний масив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Перетворення двовимірного масиву в одновимірний
            int[] flattenedArray = new int[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flattenedArray[index++] = array[i, j];
                }
            }

            return flattenedArray; // Повертаємо одновимірний масив
        }
    }
}
