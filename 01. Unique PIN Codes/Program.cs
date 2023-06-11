namespace _01._Unique_PIN_Codes
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber1 = int.Parse(Console.ReadLine());
            int maxNumber2 = int.Parse(Console.ReadLine());
            int maxNumber3 = int.Parse(Console.ReadLine());

            for (int first = 1; first <=maxNumber1; first++)
            {
                if (first % 2 == 0)
                {
                    for (int second = 1; second <=maxNumber2; second++)
                    {
                        if (second > 1 && second <= 7 && (second == 2 ||second == 3 || second == 5 || second == 7))
                        {
                            for (int third = 1; third <= maxNumber3; third++)
                            {
                                if (third % 2 == 0)
                                {
                                    Console.WriteLine($"{first} {second} {third}");
                                }
                            }
                        }
                        
                            
                    }
                }
                
                    
            }
        }
    }
}