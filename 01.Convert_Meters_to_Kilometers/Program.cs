namespace _01.Convert_Meters_to_Kilometers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kilometers = meters / 1000d;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}