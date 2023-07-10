namespace _02._Repeat_Strings
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine() // read input from the console
                .Split(" ", StringSplitOptions.RemoveEmptyEntries); // splits it by white space

            StringBuilder str = //creating string builder for improved preformance 
                new StringBuilder();

            for (int i = 0; i < input.Length; i++) // loop that iterates through every word 
            {
                string currWord = input[i]; //taking curr word
                str.Append(AppendingStringMethod(currWord)); // appends a method that appends a word
            }
            Console.WriteLine(str.ToString()); // print the final result
        }

        static string AppendingStringMethod(string input) // custom method that appends
        {
            StringBuilder str = // string builder for better preformance
                new StringBuilder();

            for (int i = 0; i < input.Length; i++) // making for loop that iterates through every char in the string
            {
                str.Append(input); // appends the char to the stringbuilder
            }
            return str.ToString(); // returns stringbuilder
        }
    }
}