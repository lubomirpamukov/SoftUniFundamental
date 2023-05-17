namespace _10.Rage_Expansion
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int gameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double screenPrice = double.Parse(Console.ReadLine());


            //Count calculation 
            int headsetCount = gameCount / 2;
            int mouseCount = gameCount / 3;
            int keyboardCount = gameCount / 6;
            int screenCount = gameCount / 12;

            //Total expenses calculcation
            double totalExpenses = (headsetCount * headsetPrice) + (mouseCount * mousePrice)
                                 + (keyboardCount * keyboardPrice) + (screenCount * screenPrice);

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");

        }
    }
}