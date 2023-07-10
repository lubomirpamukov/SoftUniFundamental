namespace _06._Replace_Repeating_Chars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    input = input.Remove(i, 1);

                    
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}