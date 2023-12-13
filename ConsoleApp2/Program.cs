using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Выберите номер практической";
            Console.Write("Введите номер практической: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 8:
                    Console.Clear();
                    Console.Title = "Практическая 8";
                    Console.Write("Введите номер задачи: ");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine("Введите натуральное число:");
                            int n = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Введтие кратность:");
                            int z = Convert.ToInt32(Console.ReadLine());

                            int count = 0;

                            for (; n > 0;)
                            {
                                if (n % z == 0)
                                {
                                    count++;
                                }
                                n /= 10;
                            }
                            Console.WriteLine("Количество цифр кратных z: {0}", count);

                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Введите список цен:");
                            string[] prices = Console.ReadLine().Split(' ');

                            int totalCost = 0;

                            for (int i = 0; i < prices.Length; i++)
                            {
                                int price = int.Parse(prices[i]);
                                if (price > 1000)
                                {
                                    totalCost += price;
                                }
                            }

                            Console.WriteLine("Общая стоимость: {0}", totalCost);
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Введите количество команд:");
                            int a = int.Parse(Console.ReadLine());

                            int positiveBalanceTeamsCount = 0;

                            for (int i = 0; i < a; i++)
                            {
                                Console.WriteLine("Введите количество выигрышей команды {0}:", i + 1);
                                int wins = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите количество проигрышей команды {0}:", i + 1);
                                int losses = int.Parse(Console.ReadLine());

                                if (wins > losses)
                                {
                                    positiveBalanceTeamsCount++;
                                }
                            }

                            Console.WriteLine("Количество команд с положительным балансом: {0}", positiveBalanceTeamsCount);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Такой задачи нет");
                            break;
                    }
                    break;
                case 9:
                    Console.Clear();
                    Console.Title = "Практическая №7";
                    Console.Write("Введите номер задачи: ");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();

                            int a = 0, m = 20;

                            double b = Math.PI / 2, h = (b - a) / m;

                            double[] values = new double[m];

                            for (int i = 0; i < m; i++)
                            {
                                // Вычисляем значение функции в i-ой точке
                                values[i] = Math.Sin(a + i * h) - Math.Cos(a + i * h);
                            }

                            // Выводим значения функции
                            for (int i = 0; i < m; i++)
                            {
                                Console.WriteLine("x = {0}, F(x) = {1}", a + i * h, values[i]);
                            }
                            break;
                        case 2:
                            // Вводим значение e
                            Console.WriteLine("Введите значение e:");
                            float e = float.Parse(Console.ReadLine());

                            // Инициализируем переменные
                            float s = 0;
                            int n = 0;

                            // Цикл по членам ряда
                            while (true)
                            {
                                // Вычисляем значение очередного члена ряда
                                float a = (n + 1)! / (2 * (n + 1))!;

                                // Если значение члена ряда меньше e, то выходим из цикла
                                if (Math.Abs(a) < e)
                                {
                                    break;
                                }

                                // Добавляем член ряда к сумме
                                s += a;

                                // Увеличиваем счетчик членов ряда
                                n++;
                            }

                            // Выводим результат
                            Console.WriteLine("Сумма ряда: {0}", s);


                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Такой задачи нет");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Такой Практической нет");
                    // Вводим значение e
                    Console.WriteLine("Введите значение e:");
                    float e = float.Parse(Console.ReadLine());

                    // Инициализируем переменные
                    float s = 0;
                    float a = 1;
                    float last_a = 0;
                    int n = 0;

                    // Цикл по членам ряда
                    while (true)
                    {
                        // Вычисляем значение очередного члена ряда
                        last_a = a;
                        a = (n + 1)! / (2 * (n + 1))!;

                        // Если значение члена ряда меньше e, то выходим из цикла
                        if (Math.Abs(a - last_a) < e)
                        {
                            break;
                        }

                        // Добавляем член ряда к сумме
                        s += a;

                        // Увеличиваем счетчик членов ряда
                        n++;
                    }

                    // Выводим результат
                    Console.WriteLine("Сумма ряда: {0}", s);
                    break;
            }
        }
    }
}