namespace _05._Average_Number
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

            }

            Console.WriteLine($"{sum / numberOfLines:f2}");
        }
    }
}