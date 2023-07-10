namespace _03._Substring
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine(); // read input from console
            string input = Console.ReadLine(); // read input from console

            while ((input.Contains(key))) // loops that iterates though the input until the text contajns the Key
            {
                input = input.Replace(key,string.Empty);// check if the input contains the key if yes replace it with empty string
            }
            Console.WriteLine(input); // print input
        }
    }
}