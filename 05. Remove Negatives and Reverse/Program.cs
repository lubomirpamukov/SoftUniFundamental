namespace _05._Remove_Negatives_and_Reverse
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine() // we alocate a list that is read from the console
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> finalList = new List<int>(); // we make a empty list to store the positive numbers 

            for (int i = 0; i < list.Count; i++) // itterate through every number of the original list
            {
                if (list[i] > 0) // if the value of the element is bigger > 0 we add it to the empty list
                {
                    finalList.Add(list[i]); // adding the positive value to the list
                }
            }

            finalList.Reverse(); // reverse the final list with positive numbers

            if (finalList.Count == default) // check if there is anything in the list , if it is default value means its empty
            {
                Console.WriteLine("empty"); // we say its empty
            }
            else // it checks that there are data stored in the empty list
            {
                Console.WriteLine(string.Join(" ", finalList)); // print the elements stored in the list
            }

            //-------------------------------------------------------------------------------------------------------------

            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            list2.RemoveAll(x => x < 0); // doing all the above in a single line xD
            list2.Reverse();
            Console.WriteLine(string.Join("", list2));
        }
    }
}