namespace _02._Change_List
{
    using System;
    using System.Runtime.InteropServices;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine() // reds list from the console
                .Split() // split the items in the input by white spaces
                .Select(int.Parse) // parses all the elements from string to int's
                .ToList(); //saves them into a list

            string command;

            while ((command = Console.ReadLine()) != "end") // reads command from the console and compare it to end
            {
                string[] currOperation = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray(); //makes string into array of strings separated by white space

                if (currOperation.Length == 2) // check if operation is "Delete " based on the lenght of the input 2 elemennts == delete
                {
                    int numberToDelete = int.Parse(currOperation[1]); // parse the number it needs to check and delete from string to int

                    for (int i = 0; i < list.Count; i++) // for cycle to check all the numbers for the number to be deleted
                    {
                        list.Remove(numberToDelete); // checks and removes all the elements with the numberToDelete value   
                    }
                }
                else if (currOperation.Length == 3) // check based on lenght if operation is "Insert"
                {
                    int number = int.Parse(currOperation[1]); // takes the value that need to be inserted and parse it to int
                    int index = int.Parse(currOperation[2]); // parse the index from string to int
                    list.Insert(index, number);
                }
            }

            Console.WriteLine(string.Join(" ", list)); // print the new list separated by spaces
        }
    }
}