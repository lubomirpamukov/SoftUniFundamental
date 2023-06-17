namespace _01._Counter_Strike
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string command;
            int battlesWon = 0;

            while ((command = Console.ReadLine()) != "End of battle"||energy < 0 )
            {
                int distance = int.Parse(command);

                if (energy - distance >= 0)
                {
                    energy -= distance;
                    battlesWon++;
                }
                else 
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
                    return;
                }

                if (battlesWon % 3 == 0)
                {
                    energy += battlesWon;
                }

            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
            }
        }
    }
}