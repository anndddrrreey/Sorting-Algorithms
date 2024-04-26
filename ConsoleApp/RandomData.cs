using System;

namespace ConsoleApp
{
    public class RandomData
    {
        public int[] GenerateRandomArray(int rows, int cols)
        {
            int[] randomArray = new int[rows * cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    randomArray[i * cols + j] = random.Next(-100, 100); // Генеруємо випадкове значення від -100 до 100
                }
            }
            
            return randomArray;
        }

        public int[] GenerateAndSetRandomArray()
        {
            Console.WriteLine("Введіть кількість рядків:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість стовпців:");
            int cols = int.Parse(Console.ReadLine());

            int[] randomArray = GenerateRandomArray(rows, cols);
            Console.WriteLine("Згенерований масив:");
            MenuManager.PrintArray(randomArray);


            return randomArray;
        }
    }
}
