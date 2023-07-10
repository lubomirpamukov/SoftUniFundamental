namespace _02._Character_Multiplier
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int shorterStringLength = Math.Min(input[0].Length, input[1].Length);
            double sum = default;

            for (int i = 0; i < shorterStringLength; i++)
            {
                char charInputOne = input[0][i];
                char charInputTwo = input[1][i];
                double currSum = charInputOne * charInputTwo;
                sum += currSum;
            }

            sum = AddAditionalChars(input, sum);

            Console.WriteLine(sum);
        }

        private static double AddAditionalChars(string[] input, double sum)
        {
            int iterations = default;
            string longerStringLeftOver = string.Empty;

            if (input[0].Length > input[1].Length)
            {
                iterations = input[0].Length - input[1].Length;
                longerStringLeftOver = input[0].Substring(input[1].Length);
            }
            else if (input[0].Length < input[1].Length)
            {
                iterations = input[1].Length - input[0].Length;
                longerStringLeftOver = input[1].Substring(input[0].Length);

            }

            for (int i = 0; i < iterations; i++)
            {
                char currChar = longerStringLeftOver[i];
                sum += currChar;
            }

            return sum;
        }
    }
}