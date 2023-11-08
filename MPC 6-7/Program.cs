namespace MPC_6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("практика: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 6:
                    Console.Write("Задание: ");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Random random = new Random();
                            int rowNumber = random.Next(1, 26);

                            int ticketPrice;

                            if (rowNumber >= 1 && rowNumber <= 3 || rowNumber == 25)
                            {
                                ticketPrice = 10;
                            }
                            else if (rowNumber >= 4 && rowNumber <= 5)
                            {
                                ticketPrice = 15;
                            }
                            else if (rowNumber >= 6 && rowNumber <= 24)
                            {
                                ticketPrice = 20;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный номер ряда.");
                                return;
                            }

                            Console.WriteLine($"Номер ряда: {rowNumber}");
                            Console.WriteLine($"Стоимость билета: {ticketPrice} рублей.");
                            break;

                        case 2:
                            Console.Write("Введите число n (10<=n<=999): ");
                            int n = int.Parse(Console.ReadLine());

                            // Находим число х
                            int x = (n % 10) * 100 + n / 10;

                            Console.WriteLine($"Число x: {x}");
                            break;
                    }
                    break;
                case 7:
                    Console.Write("Task:");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            for (int i = 80; i >= 10; i -= 2)
                                Console.WriteLine(i);
                            break;

                        case 2:
                            
                            break;

                        case 3:
                            Console.Write("Введите значение b (b >= 100): ");
                            if (int.TryParse(Console.ReadLine(), out int b) && b >= 100)
                            {
                                int sum = 0;
                                int count = 0;

                                for (int i = 100; i <= b; i++)
                                {
                                    sum += i;
                                    count++;
                                }

                                double average = (double)sum / count;

                                Console.WriteLine($"Среднее арифметическое всех чисел от 100 до {b}: {average}");
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите значение b, которое больше или равно 100.");
                            }
                            break;
                    }
                    break;
            }
        }
    }
}