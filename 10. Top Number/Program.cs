namespace _10._Top_Number
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                if (DigitDeviser(i) && OddDigit(i) )
                {
                    Console.WriteLine(i);
                    continue;
                }
            }

        }

        static bool DigitDeviser(int input) 
        {
            int sumOfDigits = default;

            while (input >0)
            {
                int currNumber = input % 10;
                sumOfDigits += currNumber;
                input /= 10;
            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        static bool OddDigit(int input) 
        {
            while (input > 0)
            {
                int currNumber = input % 10;
                if (currNumber % 2 != 0)
                {
                    return true;

                }
                input /= 10;
            }

            return false;
        }
    }
}