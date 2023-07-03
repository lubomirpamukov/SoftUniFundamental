namespace _02._Odd_Occurrences
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            string[] words = Console.ReadLine().Split();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts.Add(wordInLowerCase, 0);
                }

                counts[wordInLowerCase]++;
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write($"{count.Key} ");
                }
            }
        }
    }
}