namespace _01._Randomize_Words
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random random= new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int rndIndex = random.Next(0,input.Length-1);
                string curWord = input[i];
                input[i] = input[rndIndex];
                input[rndIndex] = curWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}