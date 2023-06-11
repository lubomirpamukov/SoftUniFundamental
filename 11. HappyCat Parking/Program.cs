namespace _11._HappyCat_Parking
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalSum = 0.0;
            

            for (int day = 1; day <= days; day++)
            {
                double daySum = 0;

                for (int hour = 1; hour <= hours; hour++)
                {

                    if (day % 2 == 0 && hour % 2 != 0)
                        daySum += 2.50;
                    else if (day % 2 != 0 && hour % 2 == 0)
                        daySum += 1.25;
                    else
                        daySum += 1;
                }
                totalSum += daySum;
                Console.WriteLine($"Day: {day} - {daySum:f2} leva");
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}