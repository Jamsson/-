namespace MPC4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("практика: ");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 4:
                    Console.Write("Задание: ");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 4:
                            Console.WriteLine("x, y");
                            double x = Convert.ToDouble(Console.ReadLine());
                            double y = Convert.ToDouble(Console.ReadLine());

                            double ax = 0;
                            double ay = 9;
                            double bx = 9;
                            double by = 0;

                            double centerX = (ax + bx) / 2;
                            double centerY = (ay + by) / 2;

                            double radius = Math.Sqrt(Math.Pow(centerX - ax, 2) + Math.Pow(centerY - ay, 2));

                            double distanceSquared = Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2);

                            if (distanceSquared < Math.Pow(radius, 2))
                                Console.WriteLine("Да");

                            else if (distanceSquared > Math.Pow(radius, 2))
                                Console.WriteLine("Нет");

                            else
                                Console.WriteLine("На границе");
                            break;
                    }
                    break;
                case 5:
                    Console.Write("Task:");
                    switch(Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Write("Введите порядковый номер месяца: ");
                            if (int.TryParse(Console.ReadLine(), out int monthNumber))
                            {
                                if (monthNumber >= 1 && monthNumber <= 12)
                                {
                                    int monthsRemaining = 12 - monthNumber;

                                    Console.WriteLine($"Осталось {monthsRemaining} месяцев до конца года.");
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный номер месяца. Введите число от 1 до 12.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Введите целое число.");
                            }
                            break;

                        case 2:
                            Console.Write("Введите первый член прогрессии P: ");
                            if (int.TryParse(Console.ReadLine(), out int P))
                            {
                                Console.Write("Введите разность прогрессии Q: ");
                                if (int.TryParse(Console.ReadLine(), out int Q))
                                {
                                    Console.Write("Введите заданный объем продукции X: ");
                                    if (int.TryParse(Console.ReadLine(), out int X))
                                    {
                                        int n = 1;
                                        int totalProduced = P;

                                        while (totalProduced <= X)
                                        {
                                            n++;
                                            totalProduced += P + (n - 1) * Q;
                                        }

                                        Console.WriteLine($"Потребуется {n} дней, чтобы общее количество продукции впервые превысило {X}.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Некорректный ввод для заданного объема продукции.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод для разности прогрессии Q.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод для первого члена прогрессии P.");
                            }
                            break;
                    }
                    break;
            }
        }
    }
}