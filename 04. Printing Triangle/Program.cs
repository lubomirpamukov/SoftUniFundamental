namespace _04._Printing_Triangle
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                PrintLine(i);
                Console.WriteLine();
            }

            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(i);
                Console.WriteLine();
            }
        }

        private static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
        }


    }
}