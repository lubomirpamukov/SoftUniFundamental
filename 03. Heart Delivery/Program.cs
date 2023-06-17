namespace _03._Heart_Delivery
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToArray();

            string command;
            int cupidIndex= default;
            int loveCounter = houses.Length;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] cmdArgs = command.Split().ToArray();
                int cupidCurrentIndex = int.Parse(cmdArgs[1]) + cupidIndex;

                if (cupidCurrentIndex > houses.Length - 1)
                {
                    cupidCurrentIndex = 0;
                }

                if (houses[cupidCurrentIndex] > 0)
                {
                    houses[cupidCurrentIndex] -= 2;

                    if (houses[cupidCurrentIndex] <= 0)
                    {
                        Console.WriteLine($"Place {cupidCurrentIndex} has Valentine's day.");
                        loveCounter--;
                    }
                }
                else if (houses[cupidCurrentIndex] <= 0)
                {
                    Console.WriteLine($"Place {cupidCurrentIndex} already had Valentine's day.");
                }

                cupidIndex = cupidCurrentIndex;
                
            }

            Console.WriteLine($"Cupid's last position was {cupidIndex}.");

            if (loveCounter > 0)
            {
                Console.WriteLine($"Cupid has failed {loveCounter} places.");
            }
            else 
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}