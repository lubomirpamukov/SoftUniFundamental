namespace _04._List_Operations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()  // reading list int from the console
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End") //while loop until end
            {
                string[] commandArgs = command.Split(); // split the command into arguments by white spaces

                if (commandArgs[0] == "Add") // if add => adds new element at the end of the list
                {
                    int firstNumber = int.Parse(commandArgs[1]);
                    list.Add(firstNumber);
                }
                else if (commandArgs[0] == "Insert") // if Insert iserts new element in the list 
                {
                    int secoundNumber = int.Parse(commandArgs[2]); // string to int so i can use it in math operations
                    int firstNumber = int.Parse(commandArgs[1]); // string to int so i can use it in math operations

                    if (ValidIndex(list, secoundNumber))
                    {
                         list.Insert(secoundNumber, firstNumber); // insert
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                }
                else if (commandArgs[0] == "Remove") // remove at given index
                {
                    int firstNumber = int.Parse(commandArgs[1]);
                    if (ValidIndex(list, firstNumber))
                    {
                    list.RemoveAt(firstNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;

                    }
                }
                else if (commandArgs[0] == "Shift") // shift 
                {
                    int count = int.Parse(commandArgs[2]); // parse additional instructions
                    if (commandArgs[1] == "left") // direction of the loop
                    {
                        ShiftLeft(list, count); // method with loop
                    }
                    else 
                    {
                        ShiftRight(list, count); // method using loop
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list)); // print the list on single line separated by white spaces
        }

        static List<int> ShiftLeft(List<int> list, int count) // method that returns rearanged array
        {
            for (int i = 0; i < count; i++) // loop to iterate and put the first number in the end of the list
            {
                int firstNumber = list[0]; // save first element in int
                list.RemoveAt(0); // remove first element
                list.Add(firstNumber); // add first element to the end
            }

            return list; // returns re areanged list
        
        }

        static List<int> ShiftRight(List<int> list, int count)// method that returns rearanged array
        {
            for (int i = 0; i < count; i++) // loop to iterate and put the first number in the end of the list
            {
                int lastNumber = list[list.Count-1]; // take the last element
                list.RemoveAt(list.Count - 1); //remove last element
                list.Insert(0,lastNumber); // insert last element at the begining
            }

            return list; // returns re areanged list

        }

        static bool ValidIndex(List<int> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                return true;
            }

            return false;
        }
    }
}