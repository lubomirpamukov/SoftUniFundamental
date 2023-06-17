namespace _01._Black_Flag
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double plunderGoal = double.Parse(Console.ReadLine());

            double totalPlunder = default(double);

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5;

                }

                if (i % 5 == 0)
                {
                    totalPlunder *= 0.7;
                }
            }

            if (totalPlunder >= plunderGoal)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {totalPlunder / plunderGoal * 100:f2}% of the plunder.");
            }



            double math = 5 / 2;
            Console.WriteLine(math);
        }
    }
}