namespace _05._Add_and_Subtract
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int sum = AdditionSum(n1, n2);

            Console.WriteLine(Substraction(sum, n3));
        }

        static int AdditionSum(int n1, int n2) 
        {
            return n1 + n2;
        }

        static int Substraction(int sum, int n3) 
        {
            return sum - n3;
        }
    }
}