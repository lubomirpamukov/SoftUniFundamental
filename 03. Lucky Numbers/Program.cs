namespace _03._Lucky_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                int firstSum = 0;
                int secondSum = 0;

                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {

                        for (int s = 1; s <= 9; s++)
                        {

                            if ((i + j) == (k + s) && (end % (i + j) == 0))
                            {
                                firstSum = i + j;
                                secondSum = k + s;
                                
                                if (firstSum == secondSum)
                                Console.Write($"{i}{j}{k}{s} ");
                            }


                        }
                    }
                }
            }
        }
    }
}