namespace _06._Rhombus_of_Stars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Горна част на ромба
            for (int row = 1; row <= n; row++)
            {
                // Отпечатване на интервали
                for (int i = 1; i <= n - row; i++)
                {
                    Console.Write(" ");
                }

                // Отпечатване на звездичка
                Console.Write("*");

                // Отпечатване на останалите звездички
                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

            // Долна част на ромба
            for (int row = n - 1; row >= 1; row--)
            {
                // Отпечатване на интервали
                for (int i = 1; i <= n - row; i++)
                {
                    Console.Write(" ");
                }

                // Отпечатване на звездичка
                Console.Write("*");

                // Отпечатване на останалите звездички
                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}