using System;
namespace _11.Multiplication_table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplyer = int.Parse(Console.ReadLine());

            if (multiplyer > 10)
            {
                Console.WriteLine($"{number} X {multiplyer} = {number * multiplyer}");

            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (multiplyer > 10)
                    {
                        break;
                    }
                    Console.WriteLine($"{number} X {multiplyer} = {number * multiplyer}");
                    multiplyer++;
                }

            }
        }

    }
}