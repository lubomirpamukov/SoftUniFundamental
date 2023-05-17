namespace _03.Elevator
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           int peopleCount = int.Parse(Console.ReadLine());
           int elevatorCapacity = int.Parse(Console.ReadLine());
           double courses = (double)peopleCount / elevatorCapacity;
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}