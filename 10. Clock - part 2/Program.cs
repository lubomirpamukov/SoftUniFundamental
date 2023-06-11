namespace _10._Clock___part_2
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    for (int secounds = 0; secounds < 60; secounds++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {secounds}");
                    }
                }
            }
        }
    }
}