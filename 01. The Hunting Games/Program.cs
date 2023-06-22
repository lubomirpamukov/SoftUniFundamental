using System;

namespace _01._The_Hunting_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double remainingWater = water * numberOfPlayers * days;
            double remainingFood = food * numberOfPlayers * days;

            double totalfood = food * numberOfPlayers * days;

            for (int i = 1; i <= days; i++)
            {
                double energyLost = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    remainingWater -= remainingWater * 0.3;
                    energy -= energyLost * 0.05;
                }
                else if (i % 3 == 0)
                {
                    totalfood = remainingFood / numberOfPlayers;
                    energy += energyLost * 0.1;

                }

                if (energy <= 0)
                {
                    break;
                }
                    energy -= energyLost;

                
                
               
            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy} energy!");
            }
            else 
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalfood} food and {remainingWater} water.");
            }
       
        }
    }
}