namespace _04._Caesar_Cipher
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder finalString = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int currCharIntValue = (int)input[i] + 3;
                finalString.Append((char)currCharIntValue);
            }
            Console.WriteLine(finalString.ToString());
        }
    }
}