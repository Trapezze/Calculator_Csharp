using System;

namespace EngineeringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2;
            int choice;

            Console.WriteLine("Добро пожаловать в инженерный калькулятор!");

            do
            {
                // Отображаем доступные операции
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Возведение в степень");
                Console.WriteLine("0. Выход");

                // Считываем выбор пользователя
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Сложение
                        Console.WriteLine("Введите первое слагаемое:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе слагаемое:");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        double sum = operand1 + operand2;
                        Console.WriteLine($"Результат: {sum}");
                        break;

                    case 2:
                        // Вычитание
                        Console.WriteLine("Введите уменьшаемое:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите вычитаемое:");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        double difference = operand1 - operand2;
                        Console.WriteLine($"Результат: {difference}");
                        break;

                    case 3:
                        // Умножение
                        Console.WriteLine("Введите первый множитель:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второй множитель:");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        double product = operand1 * operand2;
                        Console.WriteLine($"Результат: {product}");
                        break;

                    case 4:
                        // Деление
                        Console.WriteLine("Введите делимое:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите делитель:");
                        operand2 = Convert.ToDouble(Console.ReadLine());

                        if (operand2 == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль недопустимо!");
                        }
                        else
                        {
                            double division = operand1 / operand2;
                            Console.WriteLine($"Результат: {division}");
                        }
                        break;

                    case 5:
                        // Возведение в степень
                        Console.WriteLine("Введите основание:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите показатель степени:");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        double power = Math.Pow(operand1, operand2);
                        Console.WriteLine($"Результат: {power}");
                        break;

                    case 0:
                        // Выход из программы
                        Console.WriteLine("До свидания!");
                        break;

                    default:
                        // Вывод сообщения об ошибке при некорректном выборе операции
                        Console.WriteLine("Ошибка: введена некорректная операция, повторите выбор.");
                        break;
                }

                Console.WriteLine();
            }
            while (choice != 0);
        }
    }
}
