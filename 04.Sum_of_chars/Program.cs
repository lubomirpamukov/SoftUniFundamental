namespace _04.Sum_of_chars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int numberOfCycles = int.Parse(Console.ReadLine());
            int totalSum = 0;
            //logic
            for (int i = 0; i < numberOfCycles; i++)
            {
                //taking symbol from console
                char charSymbol = char.Parse(Console.ReadLine());
                //converting and adding to the totalsum
                totalSum += (int)charSymbol;
            }
            // output
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}