using System;

class Program
{
    static void Main()
    {
        double totalMoney = 0;
        string input;

        // Accumulate coins
        while ((input = Console.ReadLine()) != "Start")
        {
            double coin = double.Parse(input);
           
                switch (coin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        totalMoney += coin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
            
        }

        // Buy products
        while ((input = Console.ReadLine()) != "End")
        {
            switch (input)
            {
                case "Nuts":
                    if (totalMoney >= 2)
                    {
                        totalMoney -= 2;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Water":
                    if (totalMoney >= 0.7)
                    {
                        totalMoney -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Crisps":
                    if (totalMoney >= 1.5)
                    {
                        totalMoney -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Soda":
                    if (totalMoney >= 0.8)
                    {
                        totalMoney -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Coke":
                    if (totalMoney >= 1)
                    {
                        totalMoney -= 1;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid product");
                    break;
            }
        }

        // Print remaining balance
        Console.WriteLine($"Change: {totalMoney:f2}");
    }
}