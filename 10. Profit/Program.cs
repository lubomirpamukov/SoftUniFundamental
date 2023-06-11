namespace _10._Profit
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           int oneLev = int.Parse (Console.ReadLine());
           int twoLev = int.Parse (Console.ReadLine());
           int fiveLev = int.Parse (Console.ReadLine());
           int sumLev = int.Parse (Console.ReadLine());

            

            for (int i = 0; i <= oneLev; i++)
            {
                for (int j = 0; j <= twoLev; j++)
                {
                    for (int l = 0; l <= fiveLev; l++)
                    {
                        int currSum = i + (j * 2) + (l * 5);
                        if (currSum == sumLev)
                        {
                        Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {l} * 5 lv. = {sumLev} lv.");
                        }
                    }
                }
            }
        }
    }
}