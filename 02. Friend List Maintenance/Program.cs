namespace _02._Friend_List_Maintenance
{
    using System;
    using System.Xml.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friendList = Console.ReadLine() 
                .Split(", ").ToArray();

            string input;
            int blackCounter = 0;
            int lostCounter = 0;

            while ((input = Console.ReadLine()) != "Report") 
            {
                string[] operations = input.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (operations[0] == "Blacklist")
                {
                        int index = Array.IndexOf(friendList, operations[1]);
                        string name = operations[1];

                    if (friendList.Contains(operations[1]))
                    {
                        Console.WriteLine($"{name} was blacklisted.");
                        friendList[index] = "Blacklisted";
                        blackCounter++;
                            
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }

                }
                else if (operations[0] == "Error") 
                {
                    int index = int.Parse(operations[1]);

                    if (index >= 0 && index < friendList.Length)
                    {
                        if (friendList[index] == "Blacklisted" || friendList[index] == "Lost")
                        {
                            continue;
                        }
                        Console.WriteLine($"{friendList[index]} was lost due to an error.");
                        friendList[index] = "Lost";
                        lostCounter++;
                    }
                    else 
                    {
                        continue;
                    }
                }
                else if (operations[0] == "Change")
                {
                    int index = int.Parse(operations[1]);
                    string name = operations[2];

                    if (index >= 0 && index < friendList.Length)
                    {
                        Console.WriteLine($"{friendList[index]} changed his username to {name}.");
                        friendList[index] = name;
                    }
                }
            }

            Console.WriteLine($"Blacklisted names: {blackCounter}");
            Console.WriteLine($"Lost names: {lostCounter}");
            Console.WriteLine(string.Join(" ", friendList));
        }
    }
}