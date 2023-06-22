namespace _02._Big_Factorial
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}