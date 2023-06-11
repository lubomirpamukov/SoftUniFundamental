namespace _03._House_Party
{
    using System;
    using System.Linq;
    using System.Transactions;
    using System.Xml.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> partyList= new List<string>(); // allocating memory for the list
            int numberOfCommands = int.Parse(Console.ReadLine()); // numbers of comands that will come from the console

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] currOperation = Console.ReadLine() // breaking donw the string into array to take the needed data
                    .Split() // split by white space
                    .ToArray();

                if (currOperation.Length == 3) // check if a person is going and adds it to the list
                {
                    string name = currOperation[0]; // name of the person taken from the input

                    AddingPersons(partyList, name);
                }
                else if (currOperation.Length == 4) // 4 = name is not going
                {
                    string name = currOperation[0]; // makeing string name for easier readability

                   RemovingPersons(partyList, name);
                }
            }

            foreach (string guestName in partyList) // prints the final party list with foreach loop
            {
                Console.WriteLine(guestName);
            }
            
        }

        static void AddingPersons(List<string> partyList, string name) 
        {
            if (partyList.Contains(name)) // check if person is on the list
            {
                Console.WriteLine($"{name} is already in the list!");// says it is
                
            }
            else if (!partyList.Contains(name)) // check if its not in it
            {
                partyList.Add(name); // adds it to the list
                
            }

        }

        static void RemovingPersons(List<string> partyList, string name) 
        {
            if (partyList.Contains(name)) // checks if the person is on the list and removes it if it is.
            {
                partyList.Remove(name); // removes the name from the list.
            }
            else if (!partyList.Contains(name)) // checks if there is a person on the list with that name
            {
                Console.WriteLine($"{name} is not in the list!");
            }

        } 
    }
}