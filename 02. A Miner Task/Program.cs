namespace _02._A_Miner_Task
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerNotes = // creating dictionary
                new Dictionary<string, int>();

            string resource; // initialize empty string

            while ((resource = Console.ReadLine()) != "stop") // loop that iterates until stop input is entered
            {
                int quantity = int.Parse(Console.ReadLine()); // parse to int input from the console

                if (!minerNotes.ContainsKey(resource)) // checks if the minernotes contain the resource if it does not 
                {
                    minerNotes.Add(resource, 0); // adds the resource to the dictionary and initialize value of ) for the quantity
                }

                minerNotes[resource] += quantity; // adds the quantity of the resource
            }

            foreach (KeyValuePair<string, int> resourceType in minerNotes) // iterates through the minerNotes
            {
                Console.WriteLine($"{resourceType.Key} -> {resourceType.Value}"); // prints every resource and its quantity
            }
        }
    }
}