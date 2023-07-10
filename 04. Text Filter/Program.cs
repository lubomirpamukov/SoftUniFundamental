namespace _04._Text_Filter
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine() // taking a string of banned words
                .Split(", ", StringSplitOptions.TrimEntries); // split them into array to extract data

            string text = Console.ReadLine(); // string for console input

            for (int i = 0; i < bannedWords.Length; i++) // loop that iterates for evey word in the banned list
            {
                text = text.Replace(bannedWords[i], new string('*' , bannedWords[i].Length)); // checks if the text contains that word and replace it with asteriks
            }

            Console.WriteLine(text);// prints the output
        }
    }
}