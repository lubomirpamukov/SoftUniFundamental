namespace _07._NxN_Matrix
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            InputMatrix(input);
        }

        static void InputMatrix(int input) 
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write($"{input} ");
                }
                Console.WriteLine();
            }
        }
    }
}