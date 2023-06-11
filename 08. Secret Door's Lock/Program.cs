namespace _08._Secret_Door_s_Lock
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {

                    for (int k = 1; k <= b; k++)
                    {
                        if (k == 2 || k == 3 || k == 5 || k == 7)
                        {
                            for (int j = 1; j <= c; j++)
                            {
                                if (j % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {k} {j}");
                                }
                            }

                        }
                    }

                }

            }
        }
    }
}