namespace _06.Triples_of_Letters
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            if (number <=2)
            {
                for (int i = 'a'; i < 'c'; i++)
                {
                    char firstChar = (char)i;
                    for (int j = 'a'; j < 'c'; j++)
                    {
                        char secoundChar = (char)j;

                        for (int k = 'a'; k < 'c'; k++)
                        {
                            char thirdChar = (char)k;

                            Console.WriteLine($"{firstChar}{secoundChar}{thirdChar}");
                        }
                    }
                }
            }
            else 
            {
                for (int i = 'a'; i <= 'c'; i++)
                {
                    char firstChar = (char)i;
                    for (int j = 'a'; j <= 'c'; j++)
                    {
                        char secoundChar = (char)j;

                        for (int k = 'a'; k <= 'c'; k++)
                        {
                            char thirdChar = (char)k;

                            Console.WriteLine($"{firstChar}{secoundChar}{thirdChar}");
                        }
                    }
                }
            }
        }
    }
}