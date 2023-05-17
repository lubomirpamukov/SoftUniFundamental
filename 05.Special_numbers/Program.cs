namespace _05.Special_numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                int sum = 0;
                while(currentNumber > 0) 
                {
                    sum+= currentNumber % 10;
                    currentNumber /= 10;
                
                
                } 

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }
        }
    }
}