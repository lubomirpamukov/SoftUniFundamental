namespace _02._Letters_Combinations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            for (char i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}