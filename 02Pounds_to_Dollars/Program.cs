namespace _02Pounds_to_Dollars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());

            decimal usd = pound * 1.31m;

            Console.WriteLine($"{usd:f3}");
        }
    }
}