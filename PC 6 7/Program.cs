namespace PC_6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Выберите номер практической";
            Console.Write("Введите номер праклической: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 6:
                    Console.Clear();
                    Console.Title = "Практическая №6";
                    Console.Write("Введите номер задачи: ");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Введите номер маршрута (от 1 до 16): ");
                            if (int.TryParse(Console.ReadLine(), out int routeNumber) && routeNumber >= 1 && routeNumber <= 16)
                            {
                                string bridge;

                                if (routeNumber <= 3 || routeNumber == 5)
                                {
                                    bridge = "Южный";
                                }
                                else if (routeNumber >= 4 && routeNumber <= 8)
                                {
                                    bridge = "Центральный";
                                }
                                else if (routeNumber >= 9 && routeNumber <= 12)
                                {
                                    bridge = "Северный";
                                }
                                else
                                {
                                    bridge = "Окружной";
                                }

                                Console.WriteLine($"Автобус на маршруте {routeNumber} пойдет по {bridge} мосту.");
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Введите номер маршрута от 1 до 16.");
                            }
                            break;

                        case 2:
                            Console.Clear();
                            for (int x = 100; x < 1000; x++)
                            {
                                int lastDigit = x % 10; // Последняя цифра числа x
                                int remainingDigits = x / 10; // Оставшиеся две цифры числа x
                                int reversedRemainingDigits = (remainingDigits % 10) * 10 + remainingDigits / 10; // Переставленные цифры оставшегося числа
                                int reconstructedNumber = lastDigit * 100 + reversedRemainingDigits; // Восстановленное число

                                if (reconstructedNumber == 654)
                                {
                                    Console.WriteLine($"Число х: {x}");
                                    break; // Прекращаем перебор, если нашли число х
                                }
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Такой задачи нет");
                            break;
                    }
                    break;
                case 7:
                    Console.Clear();
                    Console.Title = "Практическая №7";
                    Console.Write("Введите номер задачи: ");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Введите значение A: ");
                            if (int.TryParse(Console.ReadLine(), out int A))
                            {
                                Console.Write("Введите значение B (B >= A): ");
                                if (int.TryParse(Console.ReadLine(), out int B) && B >= A)
                                {
                                    Console.Write("Введите цифру X: ");
                                    if (int.TryParse(Console.ReadLine(), out int X) && X >= 0 && X <= 9)
                                    {
                                        Console.Write("Введите цифру Y: ");
                                        if (int.TryParse(Console.ReadLine(), out int Y) && Y >= 0 && Y <= 9)
                                        {
                                            Console.WriteLine($"Целые числа из диапазона от {A} до {B}, оканчивающиеся на {X} или {Y}:");

                                            for (int i = A; i <= B; i++)
                                            {
                                                int lastDigit = Math.Abs(i % 10); // Получаем последнюю цифру числа

                                                if (lastDigit == X || lastDigit == Y)
                                                {
                                                    Console.WriteLine(i);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Некорректный ввод для цифры Y.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Некорректный ввод для цифры X.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод для значения B.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод для значения A.");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("Введите натуральное число n: ");
                            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
                            {
                                Console.Write($"Разложение числа {n} на простые множители: ");
                                PrimeFactors(n);
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Введите натуральное число больше 1.");
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Такой задачи нет");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Такой Практической нет");
                    break;
            }
        }
        static void PrimeFactors(int num)
        {
            int divisor = 2;

            while (num > 1)
            {
                if (num % divisor == 0)
                {
                    Console.Write(divisor + " ");

                    while (num % divisor == 0)
                    {
                        num /= divisor;
                    }
                }

                divisor++;
            }

            Console.WriteLine();
        }
    }
}