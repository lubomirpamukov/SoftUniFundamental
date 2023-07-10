namespace _03._Substring
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            while ((input.Contains(key)))
            {
                input = input.Replace(key,string.Empty);
            }
            Console.WriteLine(input);
        }
    }
}