using System;
namespace _10.Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{inputNumber} X {i} = {inputNumber * i}");
            }
        }
    }
}