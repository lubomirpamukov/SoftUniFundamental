namespace _01._Train
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine() // reading a list with wagon population from the console
                .Split() // separating the elements by white space
                .Select(int.Parse) // parsing the string to number , to use them in math operations
                .ToList(); // saving data to list
            int maxCapacity = int.Parse(Console.ReadLine()); // reading max capacity of each wagon

            string command;

            while ((command = Console.ReadLine()) != "end") // reading commands until we get end command and stop
            {
                string[] currCommand = command.Split(); // split the command by white space to extract info from it

                if (currCommand.Length == 2) // checking if the passanger have to be added to a exsisting wagon or to a new one
                {
                    int addWagonWithPassangers = int.Parse(currCommand[1]); // parsing the number of passenger to int so i can add it to the list
                    wagons.Add(addWagonWithPassangers); // adding passanger + wagon
                }
                else if (currCommand.Length == 1) // checking if the passanger have to be added to a exsisting wagon or to a new one
                {
                    int peopleToAdd = int.Parse(currCommand[0]); // parse the string to int to preform math operations

                    for (int i = 0; i < wagons.Count; i++) // for cycle that starts from the first wagon 
                    {
                        if (peopleToAdd + wagons[i] <= maxCapacity)// check if there is enough space for the people in the current wagon
                        {
                            wagons[i] += peopleToAdd;// adds the people to the excsisting wagon 
                            break; // breaks the loop becouse people are alredsdy seated no need to search in other wagons
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));

            
        }
    }
}