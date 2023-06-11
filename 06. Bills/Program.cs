namespace _06._Bills
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthCount = int.Parse(Console.ReadLine());

            int water = 20;
            int internet = 15;
            double totalElectricity = 0;
            double totalOtherExpenses = 0;

            double totalExpenses = 0;

            for (int i = 0; i < monthCount; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                double others = (electricity + water + internet) * 1.2;
                
                totalOtherExpenses += others;
                totalElectricity += electricity;
                totalExpenses += others + electricity + water + internet;
            }

            double totalWater = water * monthCount;
            double totalInternet = internet * monthCount;

            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {totalOtherExpenses:f2} lv");
            Console.WriteLine($"Average: {totalExpenses / monthCount:f2} lv");
        }
    }
}