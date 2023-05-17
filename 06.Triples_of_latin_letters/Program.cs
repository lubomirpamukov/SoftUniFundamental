namespace _06.Triples_of_latin_letters
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int outerCycle = 0; outerCycle < inputNumber; outerCycle++)
            {
                Console.WriteLine($"{(char)outerCycle}");
                for (int midCycle = 0; midCycle < outerCycle; midCycle++)
                {
                    Console.WriteLine($"{(char)midCycle}");

                    for (int innterCycle = 0; innterCycle < midCycle; innterCycle++)
                    {
                        Console.WriteLine($"{(char)innterCycle}");

                    }
                }
            }
        }
    }
}