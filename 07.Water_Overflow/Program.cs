namespace _07.Water_Overflow
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfPours = int.Parse(Console.ReadLine());
            int totalTankWater = 0;
            for (int i = 0; i < numbersOfPours; i++)
            {
                int litersTryingToPour = int.Parse(Console.ReadLine());


                if ((litersTryingToPour + totalTankWater) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalTankWater += litersTryingToPour;
                }
            }

            Console.WriteLine(totalTankWater);
        }
    }
}