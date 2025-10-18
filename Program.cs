using System;

namespace DebugPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int result = CalculateSum(numbers);
            Console.WriteLine($"Сумма чисел: {result}");
        }

        static int CalculateSum(int[] numbers)
        {
            int sum = 0;

            // Ошибка: цикл должен идти до i < numbers.Length
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}