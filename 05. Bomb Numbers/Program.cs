namespace _05._Bomb_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine() // parse list of numbers
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombInfo = Console.ReadLine() // parse array of commands
                .Split()
                .Select(int.Parse)
                .ToArray();

            int detonationCount = bombInfo[1]; // take how much detonation i have to make

            for (int i = 0; i < numbers.Count; i++) // loop to check every number nad compare it
            {
                if (numbers[i] == bombInfo[0]) // when number == bomb
                {
                    if (i + detonationCount < numbers.Count) // check if index of number + detonations are smaller than list count 
                    {
                        numbers.RemoveAt(i--);
                        for (int j = i; j < i + detonationCount; j++) // remove 1 number at a time
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                    else if (i + detonationCount > numbers.Count - 1) // if list count is smaller than index+ bomb power deleta all elements until the end of the list
                    {
                        numbers.RemoveAt(i--);                                        // this party delets the numbers to the right of the bomb
                        for (int j = i; j < numbers.Count; j++)
                        {
                            numbers.RemoveAt(i);
                        }
                        //---------------------------------------------------------- 
                    }                                                               // this party delets the number to the left of the list

                    if (i - detonationCount < 0) // this check if the power + index are less than 0 if they are we delete every thing from the begining 
                    {
                        for (int j = 0; j < detonationCount; j++)
                        {
                            numbers.RemoveAt(i--);
                        }
                    }
                    else if (i - detonationCount >= 0) // this checks if there are left numbers to the left side 
                    {
                        for (int j = 0; j < detonationCount; j++)
                        {
                            numbers.RemoveAt(i--);
                            
                        }
                    }

                }
            }

            int sum = default;

            foreach (var item in numbers)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}