namespace _03.Burger_Bus
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int cityCount = int.Parse(Console.ReadLine());
            double totalProfit = 0;

            for (int i = 1; i <= cityCount; i++)
            {
                string cityName = Console.ReadLine();
                double moneyEarned = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                bool pride = false;

                if (i % 5 == 0 )
                {
                    moneyEarned = moneyEarned * 0.9;
                    pride = true;
                }
                else if (i % 3 == 0 && pride == false)
                {
                    expenses = expenses * 1.5;
                }
               
                double profit = moneyEarned - expenses;
                totalProfit += profit;
                Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }

    }
    
}в