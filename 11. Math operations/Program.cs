namespace _11._Math_operations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(n1, operation, n2));
        }

        static int Calculation(int n1, string operation, int n2) 
        {
            int result = default;
            
            switch (operation)
            {
                case "/":
                    result = n1 / n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}