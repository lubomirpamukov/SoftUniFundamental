namespace _04._Triangle_of_Dollars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row <= col; row++)
                {
                    Console.Write($"$ ");
                }
                Console.WriteLine();
            }
        }
    }
}