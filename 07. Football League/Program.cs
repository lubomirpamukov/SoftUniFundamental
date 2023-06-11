namespace _07._Football_League
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            int sectorA = 0;
            int sectorB = 0;
            
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;

                    default:
                        break;
                }
            }

            double totalSectorA = (double)sectorA / fans * 100;
            double totalSectorB= (double)sectorB / fans * 100;

            double totalSectorV = (double)sectorV / fans * 100;
            double totalSectorG = (double)sectorG / fans * 100;

            double stadiumCapacityOccupied = (double)fans / stadiumCapacity * 100;

            Console.WriteLine($"{totalSectorA:f2}%");
            Console.WriteLine($"{totalSectorB:f2}%");

            Console.WriteLine($"{totalSectorV:f2}%");
            Console.WriteLine($"{totalSectorG:f2}%");
            Console.WriteLine($"{stadiumCapacityOccupied:f2}%");
        }
    }
}