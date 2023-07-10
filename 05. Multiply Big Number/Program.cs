namespace _05._Multiply_Big_Number
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder output = new StringBuilder();
            int leftOver = 0;

            for (int i = input.Length -1; i >= 0; i--)
            {
                int curNumber = (int)input[i] - 48;
                int result = curNumber * multiplier + leftOver;

                if (result > 9)
                {
                    leftOver = result / 10;
                    result %= 10;
                }
                else
                {
                    leftOver = 0;
                }

                output.Append(result);
            }

            if (leftOver > 0)
            {
                output.Append(leftOver);
            }

            char[] reversedOutput = output.ToString().ToCharArray();
            Array.Reverse(reversedOutput);
            string finalResult = new string(reversedOutput);

            Console.WriteLine(finalResult);
        }
    }
}