namespace _01._SoftUni_Reception
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int hours = 0;

            while (students > 0)
            {
                students -= employee1 + employee2 + employee3;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}