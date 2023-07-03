namespace _04._Word_Filter
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string[] words = Console.ReadLine().Split();

            foreach (string word in words) 
            {
                int value = word.Length;
                dictionary.Add(word, value);
            }

            foreach (var key in dictionary)
            {
                if (key.Value % 2 == 0)
                {
                    Console.WriteLine(key.Key);
                }
            }
        }
    }
}