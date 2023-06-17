namespace _02._Shopping_List
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!")
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = command.Split().ToArray();

                if (cmdArgs[0] == "Urgent")
                {
                    string item = cmdArgs[1];

                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Insert(0, item);
                    }

                    continue;
                }
                else if (cmdArgs[0] == "Unnecessary")
                {
                    string item = cmdArgs[1];

                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }

                    continue;
                }
                else if (cmdArgs[0] == "Correct")
                {
                    string oldItem = cmdArgs[1];
                    string newItem = cmdArgs[2];

                    if (shoppingList.Contains(oldItem))
                    {
                        int index = shoppingList.IndexOf(oldItem);
                        shoppingList.RemoveAt(index);
                        shoppingList.Insert(index, newItem);
                    }
                }
                else if (cmdArgs[0] == "Rearrange") 
                {
                    string item = cmdArgs[1];

                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}