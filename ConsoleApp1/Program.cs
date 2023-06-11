namespace ConsoleApp1
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           char first = char.Parse(Console.ReadLine()); 
           char last = char.Parse(Console.ReadLine()); 
           char skip = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = first; i <= last; i++)
            {
                if (i == skip)
                    continue;
                for (char j = first; j <= last; j++)
                {
                    if (j == skip)
                        continue;

                    for (char k = first; k <= last; k++)
                    {
                        if (k == skip)
                            continue;

                        Console.Write($"{i}{j}{k} ");
                        counter++;
                    }
                }
            }

            Console.Write(counter);
        }
    }
}
