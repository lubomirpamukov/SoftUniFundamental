namespace _03.Vacation
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                switch(typeOfGroup)
                    {
                        case "Students":
                            {
                                price = 8.45;
                            }
                            break;

                        case "Business":
                            {
                                price = 10.90;
                            }
                            break;

                        case "Regular":
                            {
                                price = 15;
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            {
                                price = 9.80;
                            }
                            break;

                        case "Business":
                            {
                                price = 15.60;
                            }
                            break;

                        case "Regular":
                            {
                                price = 20;
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            {
                                price = 10.46;
                            }
                            break;

                        case "Business":
                            {
                                price = 16;
                            }
                            break;

                        case "Regular":
                            {
                                price = 22.50;
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

            if (typeOfGroup == "Students" && groupCount >= 30)
            {
                price = (price * groupCount) * 0.85;
            }
            else if (typeOfGroup == "Business" && groupCount >= 100) 
            {
                price = (price * groupCount) - (price * 10);
            }
            else if (typeOfGroup == "Regular" && groupCount >= 10 && groupCount <= 20)
            {
                 price = (price * groupCount) * 0.95;
            }
            else 
            {
                price *= groupCount; 
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}