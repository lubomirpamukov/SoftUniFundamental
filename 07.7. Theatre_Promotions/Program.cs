using System;
namespace _07._7._Theatre_Promotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = (Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            double price = 0;

            switch (day)
            {
                case "Weekday":
                    if (age >=0 && age <=18)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");

                    }
                    else if (age >18 && age <= 64) 
                    {
                        price = 18;
                        Console.WriteLine($"{price}$");

                    }
                    else if (age >64 && age <=122)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");


                    }
                    else { Console.WriteLine("Error!"); }
                    break;

                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 15;
                        Console.WriteLine($"{price}$");
                    }
                    else { Console.WriteLine("Error!"); }
                    break;

                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                        Console.WriteLine($"{price}$");
                    }
                    else { Console.WriteLine("Error!"); }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}