namespace _02._Gauss__Trick
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           List <int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List <int> sumNumbers = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                sumNumbers.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }

            if (numbers.Count % 2 != 0)
            {
                sumNumbers.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", sumNumbers));
        }
    }
}