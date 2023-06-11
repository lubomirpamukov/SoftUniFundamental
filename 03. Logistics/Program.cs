namespace _03._Logistics
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            int totalCargo = 0;
            double bus = 0.0;
            double truck = 0.0;
            double train = 0.0;

            for (int i = 0; i < cargoCount; i++)
            {
                int weight = int.Parse((Console.ReadLine()));
                totalCargo += weight;

                if (weight <= 3)
                {
                    bus += weight;
                }
                else if (weight <= 11) 
                { 
                    truck+= weight;
                }
                else
                {
                    train += weight;
                }    
            }

            double totalPrice = (bus * 200) + (truck * 175) + (train * 120);
            double avragePerTon = totalPrice/totalCargo;

            double busPercentage = bus / totalCargo * 100; 
            double truckPercentage = truck / totalCargo * 100;
            double trainPercentage = train / totalCargo * 100;

            Console.WriteLine($"{avragePerTon:f2}");
            Console.WriteLine($"{busPercentage:f2}%");
            Console.WriteLine($"{truckPercentage:f2}%");
            Console.WriteLine($"{trainPercentage:f2}%");

        }
    }
}