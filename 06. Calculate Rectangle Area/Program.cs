namespace _06._Calculate_Rectangle_Area
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(width, height));
        }

        static int RectangleArea(int width, int height) 
        {
            int result = width* height;
            return result;
        }
    }
}