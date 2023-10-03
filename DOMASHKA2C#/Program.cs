using System;

class Program
{
    static void Main()
    {
        // Игра "Угадай число"
        Random random = new Random();
        int randomNumber = random.Next(0, 101);

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число от 0 до 100. Попробуйте угадать.");

        while (true)
        {
            Console.Write("Введите ваше предположение: ");
            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                if (guess == randomNumber)
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {randomNumber}.");
                    break;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }
            else
            {
                Console.WriteLine("Введите корректное число.");
            }
        }

        // Таблица умножения
        Console.WriteLine("\nТаблица умножения:");

        int[,] multiplicationTable = new int[10, 10];
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                multiplicationTable[i - 1, j - 1] = i * j;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write($"{multiplicationTable[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
