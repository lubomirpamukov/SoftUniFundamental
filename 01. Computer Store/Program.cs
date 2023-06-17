namespace _01._Computer_Store
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            double price = default;

            while ((command = Console.ReadLine()) != "special")
            {
                if (command == "regular")
                {
                    break;
                }

                double currPrice = double.Parse(command);

                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                price += currPrice;
            }

            if (price <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else 
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {price:f2}$");
                Console.WriteLine($"Taxes: {price * 0.2:f2}$");
                Console.WriteLine("-----------");

                if (command == "special")
                {
                    Console.WriteLine($"Total price: {(price * 1.2) * 0.9:f2}$");
                }
                else 
                {
                    Console.WriteLine($"Total price: {price * 1.2:f2}$");

                }
            }
        }
    }
}