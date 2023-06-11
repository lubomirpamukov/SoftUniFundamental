namespace _01._Smallest_of_Three_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(n1,n2,n3));
        }

        static int SmallestNumber(int n1, int n2, int n3) 
        {
            int result = int.MaxValue;

            if (n2 <= n1 && n2 <= n3)
            {
                result = n2;
            }
            else if (n1 <= n3 && n1 <= n2)
            {
                result = n1;
            }
            else if (n3 <= n2 && n3 <= n1) 
            {
                result = n3;                
            }
            
            return result;
        
        }
    }
}