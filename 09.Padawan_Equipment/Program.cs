namespace _09.Padawan_Equipment
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightSaberCount = Math.Ceiling(studentCount * 1.10);
            int freeBelts = studentCount / 6;

            double totalPrice = (lightSaberCount * lightSaberPrice)
                              + (studentCount * robePrice)  
                              +  ((studentCount * beltPrice) - (freeBelts * beltPrice));

            if (totalMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {totalPrice - totalMoney:f2}lv more.");
            } 
                
        }
    }
}