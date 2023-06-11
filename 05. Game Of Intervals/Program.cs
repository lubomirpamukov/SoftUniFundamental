namespace _05._Game_Of_Intervals
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());

            double totalSum = 0.0;
            double counter_0_9 = 0;
            double counter_10_19 = 0;
            double counter_20_29 = 0;
            double counter_30_39 = 0;
            double counter_40_50 = 0;
            double invalidNumberCounter = 0;

            for (int i = 0; i < rounds; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine()) ;

                if (currentNumber > 50 || currentNumber < 0)
                {
                    totalSum /= 2;
                    invalidNumberCounter++;
                    continue;
                }


                if (currentNumber >= 0 && currentNumber <= 9) 
                {
                    totalSum += currentNumber * 0.2;
                    counter_0_9++;
                }
                else if (currentNumber >= 10 && currentNumber <= 19)
                {
                    totalSum += currentNumber * 0.3;
                    counter_10_19++;
                }
                else if (currentNumber >= 20 && currentNumber <= 29)
                {
                    totalSum += currentNumber * 0.4;
                    counter_20_29++;
                }
                else if (currentNumber >= 30 && currentNumber <= 39)
                {
                    totalSum += 50;
                    counter_30_39++;
                }
                else if (currentNumber >= 40 && currentNumber <= 50)
                {
                    totalSum += 100;
                    counter_40_50++;
                }

            }

             counter_0_9 = (double)counter_0_9 / rounds * 100;
            counter_10_19 = (double)counter_10_19 / rounds * 100;
            counter_20_29 = (double)counter_20_29 / rounds * 100;
            counter_30_39 = (double)counter_30_39 / rounds * 100;
            counter_40_50 = (double)counter_40_50 / rounds * 100;
            invalidNumberCounter = (double)invalidNumberCounter / rounds * 100;

            Console.WriteLine($"{totalSum:f2}");
            Console.WriteLine($"From 0 to 9: {counter_0_9:f2}%");
            Console.WriteLine($"From 10 to 19: {counter_10_19:f2}%");
            Console.WriteLine($"From 20 to 29: {counter_20_29:f2}%");
            Console.WriteLine($"From 30 to 39: {counter_30_39:f2}%");
            Console.WriteLine($"From 40 to 50: {counter_40_50:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumberCounter:f2}%");
        }
    }
}