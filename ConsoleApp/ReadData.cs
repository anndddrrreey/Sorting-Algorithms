using System;
using System.IO;

namespace ConsoleApp
{
    public class ReadData
    {
        public static int[] ReadArrayFromFile()
        {
            Console.WriteLine("Введіть ім'я файлу:");
            string fileName = Console.ReadLine();
            string filePath = Path.Combine(@"C:\Users\User\Desktop\ConsoleApp", fileName + ".txt");

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int[] array = new int[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    array[i] = int.Parse(lines[i]);
                }

                Console.WriteLine($"Масив зчитано з файлу \"{filePath}\".");
                return array;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
                return new int[0];
            }
        }
    }
}
