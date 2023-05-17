using System;
namespace _09.Sum_of_odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= inputNumber; i++)
            {
                int oddNumber = 2 * i - 1;
                Console.WriteLine(oddNumber);
                sum += oddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}