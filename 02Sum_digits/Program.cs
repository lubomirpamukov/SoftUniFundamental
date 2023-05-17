namespace _02Sum_digits
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0) 
            {
                int numberCopy = number % 10;
                sum += numberCopy;
                number /=10;
            }
            Console.WriteLine(sum);
        }
    }
}