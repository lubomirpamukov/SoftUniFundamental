namespace _03._Word_Synonyms
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(synonym);
            }

           foreach (var key in dictionary) 
            {
                Console.WriteLine($"{key.Key} - {string.Join(", ", key.Value)}");
            }
        }
    }
}