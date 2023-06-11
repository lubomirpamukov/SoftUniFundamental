namespace _10._Multiply_Evens_by_Odds
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
       {
            int input =int.Parse(Console.ReadLine());
            input = Math.Abs(input);
            string inputString = input.ToString();
            int[] arrayInt= new int[inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                arrayInt[i] = int.Parse(inputString[i].ToString());
            }

            Console.WriteLine($"{MultiplyOfEvenAndOdds(Odd(arrayInt),Even(arrayInt))}");

        }

    

        static int Even(int[] arrayInt) 
        {
            int evenSum = default;
            foreach (int i in arrayInt) 
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
            }
            
            return evenSum;
        }

        static int Odd(int[] arrayInt) 
        {
            int oddSum = default;

            foreach (int i in arrayInt)
            {
                if (i % 2 != 0)
                {
                    oddSum += i;
                }
            }

            return oddSum;
        }

        static int MultiplyOfEvenAndOdds(int oddSum, int evenSum) 
        {
            return oddSum * evenSum;
        }
    }
}