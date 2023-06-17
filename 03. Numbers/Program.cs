namespace _03._Numbers
{
    using System;
    using System.Collections.Immutable;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isEmpty = true;
            double arrayAvrage = array.Average(); // намира средната стойност в масива
            var numbersAboveAvrage = array.Select(x => x).Where(x => x > arrayAvrage); // прави нов енюмерик който съдържа всички числа над средното
            var largestNumbers = numbersAboveAvrage.OrderByDescending(x => x).Take(5); // пренарежда нюмерика по големина и принтира 5 те най големи
                                                                                       //ако няма 5 принтира колкото има, ако няма нищо не принтира нищо
            foreach (int num in largestNumbers)
            {
                Console.Write(num + " ");
                isEmpty = false;
            }

            if (isEmpty)
            {
                Console.WriteLine("No");
            }
        }
    }
}