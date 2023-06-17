namespace _02._Treasure_Hunt
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfItems = Console.ReadLine()
                .Split("|")
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] cmdArgs = command.Split().ToArray();

                if (cmdArgs[0] == "Loot")
                {
                    LootMethod(listOfItems, cmdArgs);
                }
                else if (cmdArgs[0] == "Drop") 
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index > listOfItems.Count-1)
                    {
                        continue;
                    }
                    else 
                    {
                        DropMethod(listOfItems, cmdArgs);
                    }
                }
                else if (cmdArgs[0] == "Steal")
                {
                    StealMethod(listOfItems, cmdArgs);
                }
            }

            double sum = default;

            for (int i = 0; i < listOfItems.Count; i++)
            {
                    int length = listOfItems[i].Length;
                    sum += length;
            }

            if (sum <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else 
            {
                double averageGain = sum / listOfItems.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            
        }
        static List<string> LootMethod(List<string> listOfItems, string[] cmdArgs)
        {
            for (int i = 0; i < cmdArgs.Length - 1; i++)
            {
                if (listOfItems.Contains(cmdArgs[i+1]))
                {
                    continue;
                }
                else if (!listOfItems.Contains(cmdArgs[i+1]))
                {
                    listOfItems.Insert(0, cmdArgs[i + 1]);
                }
            }
                return listOfItems;
        }

        static List<string> DropMethod(List<string> listOfItems, string[] cmdArgs) 
        {
                int remove = int.Parse(cmdArgs[1]);
                string currItem = listOfItems[remove];
                listOfItems.RemoveAt(remove);
                listOfItems.Add(currItem);
                return listOfItems;
        }

        static List<string> StealMethod(List<string> listOfItems, string[] cmdArgs) 
        {

            int steal = int.Parse(cmdArgs[1]);

            if (steal > listOfItems.Count)
            {
                steal = listOfItems.Count;
            }

            List<string> list = new List<string>();

            for (int i = 0; i < steal; i++)
            {
                list.Add(listOfItems[listOfItems.Count - 1]);
                listOfItems.RemoveAt(listOfItems.Count - 1);
            }
            list.Reverse();
            Console.WriteLine(string.Join(", ", list));

           
            return listOfItems;
        }

        
    }
}