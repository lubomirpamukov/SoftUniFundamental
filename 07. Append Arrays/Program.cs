namespace _07._Append_Arrays
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine() // parse the command to string[]
                .Split("|")
                .ToArray();

            string[] arrangeArray = new string[arrays.Length]; // new array to rearange the exsisting one
            List<string> finalList = new List<string>(); // new list to save the changes

            for (int i = 0; i < arrays.Length; i++) // for cycle to go throug the arrays
            {
                arrangeArray[i] = arrays[arrays.Length-1 - i]; // rearrange the arrays

                for (int j = i; j < i+1 ; j++) // for  cycle for each small array to remove all the spaces between
                {
                    List<string> list = arrangeArray[j].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList(); // list that saves the individual chars
                  
                    for (int k = 0; k < list.Count; k++) // for loop that iterates through every char and adds it into the final list
                    {
                        finalList.Add(list[k]);
                    }
                    
                }
            }

            Console.WriteLine(string.Join(" ", finalList)); // print final list

        }
    }
}