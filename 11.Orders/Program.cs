namespace _11.Orders
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderCount = int.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 1; i <= orderCount; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse((Console.ReadLine()));
                int capsulesCount = int.Parse((Console.ReadLine()));

                double price = ((days * capsulesCount) * capsulePrice);
                totalSum += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}