namespace _03._Calculations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string mathOperator = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            switch (mathOperator)
            {
                case "add":
                    Addition(n1 , n2);
                    break;
                case "multiply":
                    Multiplycation(n1, n2);
                    break;
                case "subtract":
                    Subtraction(n1, n2);
                    break;
                case "divide":
                    Division(n1, n2);
                    break;

                default:
                    break;
            }
        }

        static void Addition(int n1, int n2) 
        {
            Console.WriteLine(n1 + n2);
        }

        static void Multiplycation(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }

        static void Subtraction(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }

        static void Division(int n1, int n2) 
        {
            Console.WriteLine(n1 / n2);
        }
    }
}