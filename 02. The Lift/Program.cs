namespace _02._The_Lift
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    if (wagons[i] >= 4)
                    {
                        break;
                    }


                    if (people <= 0)
                    {
                        break;
                    }

                    wagons[i]++;
                    people--;
                }
            }

            if (people == 0 && wagons[wagons.Length - 1] == 4)
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (people == 0)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else 
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}