namespace _01._Rectangle_of_10_x_10_Stars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int columns = 0; columns < 10; columns ++)
            {
                for (int row = 0; row < 10; row++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }
    }
}