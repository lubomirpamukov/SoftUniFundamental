namespace _08._Factorial_Division
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorialOne = int.Parse(Console.ReadLine());
            int factorialTwo = int.Parse(Console.ReadLine());
            factorialOne = Math.Abs(factorialOne);
            factorialTwo= Math.Abs(factorialTwo);   
            factorialOne = FactorialCalculator(factorialOne);
            factorialTwo = FactorialCalculator(factorialTwo);

            Console.WriteLine($"{(double)factorialOne / factorialTwo:f2}");
        }

        static int FactorialCalculator(int factorialNumber) 
        {
            int factorial = 1;
            for (int i = 2; i <= factorialNumber; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}