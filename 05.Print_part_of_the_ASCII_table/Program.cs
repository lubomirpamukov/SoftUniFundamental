namespace _05.Print_part_of_the_ASCII_table
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            int startCycle = int.Parse(Console.ReadLine());
            int endCycle = int.Parse(Console.ReadLine());

            //logic making a cycle that starts and ends with the input values
            for (int i = startCycle; i <= endCycle; i++)
            {
                //writing on the console and casting the integer to char
                Console.Write($"{(char)i} ");
            }

        }
    }
}