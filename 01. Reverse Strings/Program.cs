namespace _01._Reverse_Strings
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty; // creating empty string

            while ((input = Console.ReadLine()) != "end") // loop that reads input from the console and iterates until end command
            {
                Console.WriteLine($"{input} = {ReverseString(input)}"); // custom made metod that prints the input string and its reverse equivalient
            }

        }

        static string ReverseString(string input)  // string method that reverse string
        {
            StringBuilder reversedString = // creating string builder for better preformace
                new StringBuilder();

            for (int i = input.Length-1; i >= 0; i--) // reverced for loop with the length of the word
            {
                reversedString.Append(input[i]); // last symbol of the string is appendet to index 0 ... etc, reversing the string
            }

            return reversedString.ToString(); // making the string builder to string
        }
    }
}