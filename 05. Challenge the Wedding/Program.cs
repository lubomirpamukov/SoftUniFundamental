namespace _05._Challenge_the_Wedding
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int tablesCounter = 1;

            for (int menCount = 1; menCount <= men; menCount++)
            {
                for (int womenCount = 1; womenCount <= women; womenCount++)
                {
                    if (tables >= tablesCounter)
                    {
                        Console.Write($"({menCount} <-> {womenCount}) ");
                        tablesCounter++;

                    }
                    else
                        break;
                }
            }
        }
    }
}