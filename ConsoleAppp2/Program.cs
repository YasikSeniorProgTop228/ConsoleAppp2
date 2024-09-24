using System;

class Program
{
    static void Main(string[] args)
    {
        // Запит у користувача висоти трикутника
        Console.Write("Введіть висоту трикутника: ");
        int height;

        // Перевірка на правильність введення
        if (int.TryParse(Console.ReadLine(), out height) && height > 0)
        {
            for (int i = 1; i <= height; i++)
            {
                // Вивід пробілів для вирівнювання
                Console.Write(new string(' ', height - i));

                // Вивід цифр
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }

                // Перехід на новий рядок
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Будь ласка, введіть коректну висоту трикутника.");
        }
    }
}

