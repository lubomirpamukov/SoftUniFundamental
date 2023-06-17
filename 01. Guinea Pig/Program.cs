namespace _01._Guinea_Pig
{
    using System;
    using System.Transactions;

    internal class Program
    {
        static void Main(string[] args)
        {
            double foodQuantity = double.Parse(Console.ReadLine());
            double hayQuantity = double.Parse(Console.ReadLine());
            double coverQuantity = double.Parse(Console.ReadLine());
            double pigWeight = double.Parse(Console.ReadLine());

            double foodConsumption = 0.3;
            
            for (int i = 1; i <= 30; i++)
            {
                foodQuantity -= foodConsumption;

                if (i % 2 == 0)
                {
                    hayQuantity -= foodQuantity * 0.05;
                }

                if (i % 3 == 0)
                {
                    double pigsCoverCalc = pigWeight / 3;
                    coverQuantity -= pigsCoverCalc;
                }

                if (foodQuantity <= 0 || hayQuantity <= 0 || coverQuantity <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
            }

            if (foodQuantity > 0 && hayQuantity > 0 && coverQuantity > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodQuantity:f2}, Hay: {hayQuantity:f2}, Cover: {coverQuantity:f2}.");
            }

        }
    }

    
}