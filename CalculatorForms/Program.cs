using System;

namespace EngineeringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2;
            int choice;

            Console.WriteLine("����� ���������� � ���������� �����������!");

            do
            {
                // ���������� ��������� ��������
                Console.WriteLine("�������� ��������:");
                Console.WriteLine("1. ��������");
                Console.WriteLine("2. ���������");
                Console.WriteLine("3. ���������");
                Console.WriteLine("4. �������");
                Console.WriteLine("5. ���������� � �������");
                Console.WriteLine("0. �����");

                // ��������� ����� ������������
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // ��������
                        Console.WriteLine("������� ������ ���������:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("������� ������ ���������:");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        double sum = operand1 + operand2;
                        Console.WriteLine($"���������: {sum}");
                        break;

                    case 2:
                        // ���������
                        Console.WriteLine("������� �����������:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("������� ����������:");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        double difference = operand1 - operand2;
                        Console.WriteLine($"���������: {difference}");
                        break;

                    case 3:
                        // ���������
                        Console.WriteLine("������� ������ ���������:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("������� ������ ���������:");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        double product = operand1 * operand2;
                        Console.WriteLine($"���������: {product}");
                        break;

                    case 4:
                        // �������
                        Console.WriteLine("������� �������:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("������� ��������:");
                        operand2 = Convert.ToDouble(Console.ReadLine());

                        if (operand2 == 0)
                        {
                            Console.WriteLine("������: ������� �� ���� �����������!");
                        }
                        else
                        {
                            double division = operand1 / operand2;
                            Console.WriteLine($"���������: {division}");
                        }
                        break;

                    case 5:
                        // ���������� � �������
                        Console.WriteLine("������� ���������:");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("������� ���������� �������:");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        double power = Math.Pow(operand1, operand2);
                        Console.WriteLine($"���������: {power}");
                        break;

                    case 0:
                        // ����� �� ���������
                        Console.WriteLine("�� ��������!");
                        break;

                    default:
                        // ����� ��������� �� ������ ��� ������������ ������ ��������
                        Console.WriteLine("������: ������� ������������ ��������, ��������� �����.");
                        break;
                }

                Console.WriteLine();
            }
            while (choice != 0);
        }
    }
}
