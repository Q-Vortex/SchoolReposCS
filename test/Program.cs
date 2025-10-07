using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число с точкой:");
        
        // Читаем строку и парсим в double
        string input = Console.ReadLine();
        if (double.TryParse(input, out double num))
        {
            Console.WriteLine("Вы ввели число: " + num);
        }
        else
        {
            Console.WriteLine("Некорректный ввод!");
        }
    }
}
