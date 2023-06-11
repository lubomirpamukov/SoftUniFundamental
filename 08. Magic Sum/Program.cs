namespace _08._Magic_Sum
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int magicSum = default;

                for (int j = i+1; j < array.Length; j++)
                {
                    if (array.Length < i + 1)
                        break;
                    magicSum = array[i] + array[j];


                    if (magicSum == magicNumber)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                    magicSum = 0;
                }
            }
        }
    }
}