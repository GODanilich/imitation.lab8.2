using System;

namespace lab8._2__The_ball_of_predictions_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.2;
            double b = 0.2;
            double c = 0.2;
            double d = 0.2;
            double e = 0.2;
            Console.WriteLine("Шар предсказаний");
            Console.WriteLine("Варианты ответа:");
            Console.WriteLine("\tОднозначно да");
            Console.WriteLine("\tСкорее всего да");
            Console.WriteLine("\t50/50");
            Console.WriteLine("\tСкорее всего нет.");
            Console.WriteLine("\tБез шансов\n");
            Console.WriteLine("Чтобы задать вопрос нажми \"Q\".");
            Console.WriteLine("Чтобы задать вероятности ответов нажми \"P\".");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        Console.WriteLine("\nСлушаю твой вопрос:");
                        var question = Console.ReadLine();
                        while (question == string.Empty)
                        {
                            Console.WriteLine("\nВсе еще жду вопрос");
                            question = Console.ReadLine();
                        }
                        Random random = new Random();
                        var answer = random.NextDouble();
                        if (answer < a)
                        {
                            Console.WriteLine("\tОднозначно да\n");
                            continue;
                        }
                        answer -= a;
                        if (answer < b)
                        {
                            Console.WriteLine("\tСкорее всего да.\n");
                            continue;
                        }
                        answer -= b;
                        if (answer < c)
                        {
                            Console.WriteLine("\t50/50\n");
                            continue;
                        }
                        answer -= c;
                        if (answer < d)
                        {
                            Console.WriteLine("\tСкорее всего нет.\n");
                            continue;
                        }
                        Console.WriteLine("\tБез шансов\n");
                        break;

                    case ConsoleKey.P:
                        Console.WriteLine("\nПоследовательно вводите вероятности:");
                        Console.Write("Вероятность \"Однозначно да\": ");
                        while (!double.TryParse(Console.ReadLine(), out a) || a > 1 || a < 0)
                        {
                            Console.WriteLine("\tНекорректно введённое значение.");
                        }
                        Console.WriteLine($"\tДля \"Однозначно да\" установлено значение: {a}.\n");

                        Console.Write("Вероятность \"Скорее всего да.\": ");
                        while (!double.TryParse(Console.ReadLine(), out b) || b > 1 || b < 0)
                        {
                            Console.WriteLine("\tНекорректно введённое значение.");
                        }
                        Console.WriteLine($"\tДля \"Скорее всего да.\" установлено значение: {b}.\n");

                        Console.Write("Вероятность \"50/50\": ");
                        while (!double.TryParse(Console.ReadLine(), out c) || c > 1 || c < 0)
                        {
                            Console.WriteLine("\tНекорректно введённое значение.");
                        }
                        Console.WriteLine($"\tДля \"50/50\" установлено значение: {c}.\n");

                        Console.Write("Вероятность \"Скорее всего нет.\": ");
                        while (!double.TryParse(Console.ReadLine(), out d) || d > 1 || d < 0)
                        {
                            Console.WriteLine("\tНекорректно введённое значение.");
                        }
                        Console.WriteLine($"\tДля \"Скорее всего нет.\" установлено значение: {d}.\n");

                        Console.Write("Вероятность \"Без шансов\": ");
                        while (!double.TryParse(Console.ReadLine(), out e) || e > 1 || e < 0)
                        {
                            Console.WriteLine("\tНекорректно введённое значение.");
                        }
                        Console.WriteLine($"\tДля \"Без шансов\" установлено значение: {e}.\n");

                        break;

                    case ConsoleKey.Escape:
                        // Закрытие программы при нажатии клавиши ESC
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
                
            }
        }
    }
}
