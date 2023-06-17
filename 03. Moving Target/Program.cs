namespace _03._Moving_Target
{
    using System;
    using System.ComponentModel;
    using System.Data;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End") 
            {
                string[] cmdArgs = command.Split().ToArray();

                if (cmdArgs[0] == "Shoot")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int power = int.Parse(cmdArgs[2]);

                    if (ValidIndex(targets, index))
                    {
                        if (targets[index] - power > 0)
                        {
                            targets[index] -= power;
                        }
                        else
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (cmdArgs[0] == "Add")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int value = int.Parse(cmdArgs[2]);

                    if (ValidIndex(targets,index))
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                }
                else if (cmdArgs[0] == "Strike") 
                {
                    int index = int.Parse(cmdArgs[1]);
                    int radius = int.Parse(cmdArgs[2]);
                    if (index + radius > targets.Count - 1 || index - radius < 0)
                    {
                        Console.WriteLine($"Strike missed!");
                        continue;
                    }
                    else 
                    {
                        if (ValidIndex(targets, index + radius) && ValidIndex(targets, index - radius))
                        {
                            targets.RemoveRange(index - radius, 1 + radius * 2);
                        }

                    }
                }
            
            }

            if (command == "End")
            {
                Console.WriteLine(string.Join("|", targets));
            }
        }

        static bool ValidIndex(List<int> targets, int index) 
        {
            if (index >= 0 && index < targets.Count)
            {
                return true;
            }

            return false;
        }
    }
}