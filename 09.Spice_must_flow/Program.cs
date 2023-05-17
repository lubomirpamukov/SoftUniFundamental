namespace _09.Spice_must_flow
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int mineResources = int.Parse(Console.ReadLine());
            int dayCounter = 0;
            int totalRescources = 0;
            while (mineResources >= 100)
            {
                totalRescources += mineResources;
                mineResources -= 10;
                dayCounter++;
                totalRescources -= 26; //worker consumption
                if (mineResources < 100)
                {
                    totalRescources -= 26;
                }
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(totalRescources);
        }
    }
}