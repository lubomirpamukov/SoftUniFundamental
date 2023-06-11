namespace _09._Palindrome_Integers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END" ) //въртя цикъл до команда енд
            {
                Console.WriteLine(PalindromeCheck(input)); // проверявам и печатам масива
            }


        }

        static string PalindromeCheck(string input) 
        {
            string result;
            char[] inputArray = input.ToArray(); // превръщам стринга в масив от символи
            char[] reverseArray = inputArray; // правя копие от масива символи за да го ревърсна
            Array.Reverse(reverseArray); // ревърсвам копието на масива
            string reversedInput = new string(reverseArray); // превръщам копието отново в стринг за да го сравня

            if (input == reversedInput) // сравнявам дали ревърс стринга е еднакъв със оригиналния
            {

                return result = "true";
            }
            else
            {
                return result = "false";

            }
        }
    }
}