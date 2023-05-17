
namespace _06.Strong_number
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int n = inputNumber;
            int sum = 0;

            while (n > 0) 
            {
                int digit = n % 10;
                int factorial = 1;

                for (int i = 2; i <= digit; i++)
                {
                    factorial *= i;
                }
                    sum += factorial;
                n /= 10;
            }

            if (inputNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}