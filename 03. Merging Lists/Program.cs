namespace _03._Merging_Lists
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           List <int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List <int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = Math.Min(firstList.Count, secondList.Count);

            List<int> finalList= new List<int>();

            for (int i = 0; i < n; i++)
            {
                finalList.Add(firstList[i]);
                finalList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = n; i < firstList.Count; i++)
                {
                    finalList.Add(firstList[i]);
                }
            }
            else if (secondList.Count > firstList.Count) 
            {
                for (int i = n; i < secondList.Count; i++)
                {
                    finalList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}