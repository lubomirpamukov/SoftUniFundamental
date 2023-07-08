namespace _04._Word_Filter
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>(); // making dictionary

            string[] words = Console.ReadLine().Split(); // making string array with console input

            foreach (string word in words) // filing up the dictionary
            {
                int value = word.Length; // taking word length to see if the char count is even or odd
                dictionary.Add(word, value); // filing the dictionary with KeyValuePair
            }

            foreach (var key in dictionary) // iterate thourgh all words
            {
                if (key.Value % 2 == 0) // check if the word have even count of chars
                {
                    Console.WriteLine(key.Key); // print word with even count chars
                }
            }
        }
    }
}