namespace Hunting_Games_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());

            double remainingWater = waterPerDay * numberOfPlayers * days;
            double remainingFood = foodPerDay * numberOfPlayers * days;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;

                if (i % 2 == 0)
                {
                    energy *= 0.95;
                    remainingWater -= remainingWater * 0.3;
                }

                if (i % 3 == 0)
                {
                    remainingFood -= (remainingFood / numberOfPlayers);
                    energy *= 1.1;
                }

                if (energy <= 0)
                {
                    break;
                }
            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {remainingFood:F2} food and {remainingWater:F2} water.");
            }

        }

    }
}
