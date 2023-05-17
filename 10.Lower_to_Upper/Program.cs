namespace _10.Lower_to_Upper
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (char.IsUpper(c))
            {
                Console.WriteLine("upper-case");
            }
            else 
            {
                Console.WriteLine("lower-case");
            }
            
        }
    }
}