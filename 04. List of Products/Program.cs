namespace _04._List_of_Products
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> products= new List<string>();

            for (int i = 0; i < count; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");

            }
            
        }
    }
}