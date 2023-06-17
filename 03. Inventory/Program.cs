using System.Data;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine() // reads a list of strings
                .Split(", ")
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Craft!") // loop until the command Craft stops is
            {
                string[] cmdArgs = command.Split(" - "); // separates the command string to arguments

                if (cmdArgs[0] == "Collect") // if argument is collect
                {
                    string item = cmdArgs[1]; // making variable with the data of the item for easy readability

                    if (items.Contains(item)) // if there is that kind of items alredy in the list we dont add it 
                    {
                        continue; // breaks the itteration
                    }
                    else
                    {
                        items.Add(item); // if there is not item in this items list it adds it
                    }
                }
                else if (cmdArgs[0] == "Drop") // 
                {
                    string item = cmdArgs[1];

                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }

                    continue;
                }
                else if (cmdArgs[0] == "Combine Items")
                {
                    string[] cmdArgsCombine = cmdArgs[1].Split(":").ToArray();

                    if (items.Contains(cmdArgsCombine[0]))
                    {
                        int index = items.IndexOf(cmdArgsCombine[0]);
                        items.Insert(index + 1, cmdArgsCombine[1]);
                    }

                    continue;
                }
                else if (cmdArgs[0] == "Renew") 
                {
                    string item = cmdArgs[1];

                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ",items));
        }
    }
}