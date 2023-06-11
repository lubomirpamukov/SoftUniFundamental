namespace _03._Characters_in_Range
{
    using System;
    using System.Threading.Tasks.Dataflow;

    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", PrintCharRow(a, b)));
        }

        static string[] PrintCharRow(char a, char b) 
        {
            char c = default;
            if (a > b)
            {
                c = b;
                b = a;
                a = c;
            }

            a++;
            char[] arrayChar = new char[b - a];
            int arrayIndex = 0;

            for (char i = a; i < b; i++)
            {
                arrayChar[arrayIndex] = i;
                arrayIndex++;
            }

            string[] stringArray = arrayChar
                .Select(c => c.ToString())
                .ToArray();

            return stringArray;

        }
    }
}