namespace _05._Orders
{
    using System;
    using System.Diagnostics;

    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{Calculation(quantity, 1.50):f2}");
                    break;
                case "water":
                    Console.WriteLine($"{Calculation(quantity, 1.00):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{Calculation(quantity, 1.40):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{Calculation(quantity, 2.00):f2}");
                    break;
                default:
                    break;
            }
        }

        static double Calculation(int quantity, double price)
        {
            double result = quantity* price;
            return result;
        }

        
    }
}