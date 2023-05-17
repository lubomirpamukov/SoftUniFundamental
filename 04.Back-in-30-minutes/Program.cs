using System;
namespace _04.Back_in_30_minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 30;

            if (minute >=60)
            {
                minute -=60;
                hour += 1;
            }

            if (hour >=24)
            {
                hour -= 24;
            }

            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}