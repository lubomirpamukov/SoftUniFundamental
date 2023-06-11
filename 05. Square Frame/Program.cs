namespace _05._Square_Frame
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char nSymbol = '-';

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    if (column == 0 && row == 0 || column == n-1 && row == 0 || row == n-1 && column == 0 || row == n - 1 && column == n-1)
                    {
                        Console.Write($"+ ");
                        continue;
                    }

                    if (column == 0)
                    {
                        Console.Write($"| ");
                        continue;
                    }

                    if (column == n - 1)
                    {
                        Console.Write($"|");
                        continue;
                    }

                    Console.Write($"- ");
                }
                Console.WriteLine();
            }
        }
    }
}