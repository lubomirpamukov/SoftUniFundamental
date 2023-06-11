namespace _06._Middle_Characters
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(WhereTheMagicHappens(input));
        }

        static char[] WhereTheMagicHappens(string input) 
        {
            char[] charArray = input.ToCharArray();
            int middleIndex = charArray.Length / 2;
            int counter = 0;
             
            if (charArray.Length % 2 != 0)
            {
                counter++;
            }
            else if (charArray.Length % 2 == 0) 
            {
                counter += 2;
            }

            char[] finalArray = new char[counter];

            if (charArray.Length % 2 != 0)
            {
                finalArray[0] = charArray[middleIndex];
            }
            else if (charArray.Length % 2 == 0)
            {
                finalArray[0] = charArray[middleIndex-1];
                finalArray[1] = charArray[middleIndex];
            }

            return finalArray;
        }
    }
}