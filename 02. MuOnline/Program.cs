namespace _02._MuOnline
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoin = 0;
            int room = 1;

            string[] maze = Console.ReadLine()
                .Split('|')
                .ToArray();

            for (int i = 0; i < maze.Length; i++)
            {
                string[] cmdArgs = maze[i].Split(' ');

                if (cmdArgs[0] == "potion")
                {
                    int healed = int.Parse(cmdArgs[1]);

                    if (health + healed >= 100)
                    {
                        int currHealth = health + healed - 100;
                        int healedFor = healed - currHealth;
                        health = 100;
                        Console.WriteLine($"You healed for {healedFor} hp.");

                    }
                    else
                    {
                        health += healed;
                        Console.WriteLine($"You healed for {healed} hp.");
                    }
                        Console.WriteLine($"Current health: {health} hp.");
                }
                else if (cmdArgs[0] == "chest")
                {
                    int coins = int.Parse(cmdArgs[1]);
                    Console.WriteLine($"You found {coins} bitcoins.");
                    bitcoin += coins;
                }
                else //fighting monster
                {
                    string monster = cmdArgs[0];
                    int attack = int.Parse(cmdArgs[1]);
                    health -= attack;

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        break;
                    }
                    else if (health >= 0) 
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }

                room++;
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoin}");
                Console.WriteLine($"Health: {health}");
            }
            else if (health <= 0) 
            { 
                Console.WriteLine($"Best room: {room}");
            }
        }

    }
}