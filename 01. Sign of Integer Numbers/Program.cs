namespace _01._Sign_of_Integer_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            PositiveNegative(int.Parse(Console.ReadLine()));

        }

        static void PositiveNegative( int n) 
        {
            if (n > 0)
            {
                Console.WriteLine("The number {0} is positive.", n);

            }
            else if (n == 0)
            {
                Console.WriteLine("The number {0} is zero.", n);
            }
            else if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
           
        }
    }
}