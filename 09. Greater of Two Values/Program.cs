namespace _09._Greater_of_Two_Values
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(input1, input2));
            }
            else if (type == "char")
            {
                char input1 = char.Parse(Console.ReadLine());
                char input2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(input1, input2));

            }
            else if (type == "string") 
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                Console.WriteLine(GetMax(input1, input2));

            }
        }

        static int GetMax(int input1, int input2) 
        {
            int result = default;
            

            if (input1 > input2)
            {
                result = input1;
            }
            else
            {
                result = input2;
            }
            return result;

        }

        static char GetMax(char input1, char input2)
        {
            char result = default;

            if (input1 > input2)
            {
                result = input1;
            }
            else
            {
                result = input2;
            }

            return result;
        }

        static string GetMax(string input1, string input2)
        {
            int compare = string.Compare(input1, input2);
            string result = string.Empty;

            if (compare > 0)
            {
                result = input1;
            }
            else
            {
                result = input2;
            }

            return result;
        }
    }
}