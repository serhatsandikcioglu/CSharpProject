using System;

namespace FibonacciAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisinin derinliğini girin: ");
            int depth = int.Parse(Console.ReadLine());

            double average = CalculateFibonacciAverage(depth);

            Console.WriteLine($"Fibonacci serisindeki rakamların ortalaması: {average}");
        }

        static double CalculateFibonacciAverage(int depth)
        {
            int[] fibonacci = new int[depth];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            double sum = fibonacci[0] + fibonacci[1];

            for (int i = 2; i < depth; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                sum += fibonacci[i];
            }

            double average = sum / depth;

            return average;
        }
    }
}