namespace _02._Repeat_Strings
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder str =
                new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string currWord = input[i];
                str.Append(StringManipulation(currWord));
            }
            Console.WriteLine(str.ToString());
        }

        static string StringManipulation(string input) 
        {
            StringBuilder str =
                new StringBuilder();

            int stringLength = input.Length;

            for (int i = 0; i < input.Length; i++)
            {
                str.Append(input);
            }
            return str.ToString();
        }
    }
}