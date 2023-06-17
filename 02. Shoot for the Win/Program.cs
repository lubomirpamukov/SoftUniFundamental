namespace _02._Shoot_for_the_Win
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;
            int shotCounter = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int shootAt = int.Parse(command);

                if (shootAt < 0 || shootAt > targets.Length-1)
                {
                    continue;
                }

                int currTarget = targets[shootAt];

                if (targets[shootAt] == -1)
                {
                    break;
                }

                targets[shootAt] = -1;
                shotCounter++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == - 1)
                    {
                        continue;
                    }
                    else if (currTarget < targets[i])
                    {
                        targets[i] -= currTarget;
                    }
                    else if (currTarget >= targets[i]) 
                    {
                        targets[i] += currTarget;
                    }
                }

            }

            if (command == "End")
            {
                Console.WriteLine($"Shot targets: {shotCounter} -> {string.Join(" ",targets)}");
            }
        }
    }
}