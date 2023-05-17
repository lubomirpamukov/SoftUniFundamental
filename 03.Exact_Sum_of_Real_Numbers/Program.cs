namespace _03.Exact_Sum_of_Real_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopCount = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < loopCount; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine($"{sum}");
        }
    }
}