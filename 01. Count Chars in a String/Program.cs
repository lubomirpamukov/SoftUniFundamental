namespace _01._Count_Chars_in_a_String
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dictionery =
                new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (!char.IsWhiteSpace(ch))
                {
                    if (!dictionery.ContainsKey(ch))
                    {
                        dictionery[ch] = 0;
                    }
                    dictionery[ch]++;
                }
            }

            foreach (var letter in dictionery)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}