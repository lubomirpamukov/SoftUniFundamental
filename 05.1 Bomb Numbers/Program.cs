using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine() // reads int list from the console
            .Split()
            .Select(int.Parse)
            .ToList();

        int[] bombInfo = Console.ReadLine() // reads bomb information
            .Split()
            .Select(int.Parse)
            .ToArray();

        int bombNumber = bombInfo[0]; // detonation number
        int bombPower = bombInfo[1]; // detonation power

        while (numbers.Contains(bombNumber)) // while loop that iterates until there no more bombs left
        {
            int bombIndex = numbers.IndexOf(bombNumber); // finds the index of the bomb

            int leftIndex = Math.Max(bombIndex - bombPower, 0); // takes the position of the bomb and substracts the power
                                                                // , if the number gets >0 math.max over write it to 0 to not leave bounderies


            int rightIndex = Math.Min(bombIndex + bombPower, numbers.Count - 1);// bomb index+ bomb power compares them to the length of the list
                                                                                // if longer dont allow it to escape bounderies

            numbers.RemoveRange(leftIndex, rightIndex - leftIndex + 1); // removes the blown up numbers from the list
        }

        int sum = numbers.Sum(); // sums all the numbers in the list
        Console.WriteLine(sum);
    }
}