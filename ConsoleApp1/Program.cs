namespace ConsoleApp1
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string package = Console.ReadLine();
            string discountInput = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double totalDayPrice = default;
            double discount = default;

            if (days < 1)
            {
                Console.WriteLine($"Days must be positive number!");
                return;
            }


            if (city == "Bansko" || city == "Borovets")
            {
                switch (package)
                {
                    case "withEquipment":
                        totalDayPrice = 100;
                        discount = 0.9;
                        break;
                    case "noEquipment":
                        totalDayPrice = 80;
                        discount = 0.95;

                        break;
                    default:
                        break;
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                switch (package)
                {
                    case "withBreakfast":
                        totalDayPrice = 130;
                        discount = 0.88;

                        break;
                    case "noBreakfast":
                        totalDayPrice = 100;
                        discount = 0.93;

                        break;
                    default:
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            double totalPrice = totalDayPrice * days; 

            if (discountInput == "yes")
            {
                totalDayPrice *= discount;
                totalPrice *= discount;
            }

            if (days > 7)
            {
                totalPrice -= totalDayPrice;
            }

            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
        }
    }
}
