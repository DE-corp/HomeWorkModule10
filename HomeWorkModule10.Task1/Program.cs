using System;

namespace HomeWorkModule10.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.X = SetValue();
            calculator.Y = SetValue();

            var result = calculator.Sum();

            Console.WriteLine($"\nРезультат сложения равен: {result}");
        }

        private static int SetValue()
        {
            while (true)
            {
                Console.Write("Введите число: ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Введено некорректное значение. Введите еще раз! " + ex.Message);
                }
            }
        }
    }
}
