namespace _09._Sum_of_Two_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool flag = true;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (j+i == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        flag = false;
                        return;
                    }
                }
            }

            if ( flag == true)
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}