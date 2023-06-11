namespace _02._Vowels_Count
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(StringVowels(input));
        }

        static int StringVowels(string input) 
        {
            int counter = default;
            input= input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar == 'a' || currChar == 'o' || currChar == 'e' || currChar =='u' || currChar == 'i')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}