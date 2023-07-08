namespace _03._Word_Synonyms
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>(); //creating dictionary

            int n = int.Parse(Console.ReadLine()); // parsing integer number from the console

            for (int i = 0; i < n; i++) // loop that iterates n times and fill the dictionary
            {
                string word = Console.ReadLine(); // taking data as input for the dictionary
                string synonym = Console.ReadLine(); // taking data as input from the dictionary

                if (!dictionary.ContainsKey(word)) // if there is not Key same as the input
                {
                    dictionary.Add(word, new List<string>()); // adding the key and for Value empty list
                }

                dictionary[word].Add(synonym); // filling the list with data
            }

           foreach (var key in dictionary) // printing the dictionary
            {
                Console.WriteLine($"{key.Key} - {string.Join(", ", key.Value)}");
            }
        }
    }
}