namespace _03._Man_O_War
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToArray();

            int[] warShip = Console.ReadLine()
               .Split(">")
               .Select(int.Parse)
               .ToArray();

            int maxHealthCapacity = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] cmdArgs = command.Split().ToArray();

                if (cmdArgs[0] == "Fire")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int damage = int.Parse(cmdArgs[2]);

                    if (IsValidIndex(index, warShip))
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (cmdArgs[0] == "Defend")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int damage = int.Parse(cmdArgs[3]);

                    if (IsValidIndex(startIndex, pirateShip) && IsValidIndex(endIndex, pirateShip))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (cmdArgs[0] == "Repair")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int health = int.Parse(cmdArgs[2]);

                    if (IsValidIndex(index, pirateShip))
                    {
                        pirateShip[index] += health;

                        if (pirateShip[index] > maxHealthCapacity)
                        {
                            pirateShip[index] = maxHealthCapacity;
                        }
                    }
                }
                else if (cmdArgs[0] == "Status")
                {
                    int repairCounter = pirateShip.Count(section => section < maxHealthCapacity * 0.2);

                    Console.WriteLine($"{repairCounter} sections need repair.");
                }
            }

            int pirateShipSum = pirateShip.Sum();
            int warShipSum = warShip.Sum();

            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warShipSum}");
        }

        static bool IsValidIndex(int index, int[] ship)
        {
            return index >= 0 && index < ship.Length;
        }
    }
}