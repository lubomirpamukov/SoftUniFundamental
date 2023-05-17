namespace _01.Integer_operations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long additionResult = (long)(firstNumber + secondNumber);
            long divideResult = (long)(additionResult / thirdNumber);
            long multiplyResult = (long)(divideResult * fourthNumber);
            Console.WriteLine(multiplyResult);
        }
    }
}