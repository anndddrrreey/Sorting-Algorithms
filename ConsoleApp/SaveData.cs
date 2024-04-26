using System;
using System.IO;

namespace ConsoleApp
{
    public class SaveData
    {
        public static void SaveArray(int[] array)
        {
            Console.WriteLine("Введіть ім'я файлу для збереження:");
            string fileName = Console.ReadLine();
            string filePath = Path.Combine(@"C:\Users\User\Desktop\ConsoleApp", fileName + ".txt");

            try
            {
                string content = string.Join(Environment.NewLine, array);
                File.WriteAllText(filePath, content);

                Console.WriteLine($"Масив збережено у файлі \"{filePath}\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
