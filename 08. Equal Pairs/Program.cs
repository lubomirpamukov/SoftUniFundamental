namespace _08._Equal_Pairs
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPairs = int.Parse(Console.ReadLine());
            int biggestCouple = int.MinValue;
            int equalPairsCount = 1;
            int maxDifference = 0;

            for (int i = 0; i < numberPairs; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int coupleSum = firstNumber + secondNumber;
                int difference;
                if (coupleSum == biggestCouple)
                {
                    equalPairsCount++;
                }

                if (coupleSum >= biggestCouple)
                {
                    difference = coupleSum - biggestCouple;
                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                    }
                    biggestCouple = coupleSum;
                }
                else 
                {
                    difference = biggestCouple - coupleSum;
                    if (difference > maxDifference) ;
                    {
                        maxDifference = difference;
                    }
                
                }
            }

            if (equalPairsCount == numberPairs)
            {
                Console.WriteLine($"Yes, value={biggestCouple}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}