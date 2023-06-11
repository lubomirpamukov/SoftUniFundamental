namespace _04._Car_Number
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        for (int s = start; s <= end; s++)
                        {
                            if (i % 2 == 0 && s % 2 != 0 && i > s && (j + k) % 2 == 0 || i % 2 != 0 && s % 2 == 0 && i > s && (j+k) % 2 == 0)
                            {
                                Console.Write($"{i}{j}{k}{s} ");
                            }
                        }
                    }
                }
            }
        }
    }
}