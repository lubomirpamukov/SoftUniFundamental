namespace _01._Back_To_The_Past
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int ivanYearsOld = 17;
            double moneyLeft = inheritedMoney;

            for (int startYear = 1800;  startYear <= yearToLive; startYear++)
            {
                ivanYearsOld++;
                if (startYear % 2 == 0)
                {
                    inheritedMoney -= 12_000;
                }
                else 
                {
                    inheritedMoney -= 12_000 + (50.00 * ivanYearsOld);
                }
            }


            if (inheritedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}