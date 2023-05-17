namespace _09.Chars_to_string
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            string result = a.ToString() + b.ToString() + c.ToString();
            Console.WriteLine(result);
        }

    }
}