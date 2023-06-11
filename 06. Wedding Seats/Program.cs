namespace _06._Wedding_Seats
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            char endSector = char.Parse(Console.ReadLine());
            int RowCount = int.Parse(Console.ReadLine());
            int oddCount = int.Parse(Console.ReadLine());
            int placeCounter = 0;
            int evenCount = oddCount + 2;

            for (char i = 'A'; i <= endSector; i++)
            {

                for (int j = 1; j <= RowCount; j++)
                {
                    if (j % 2 != 0)
                    {


                        for (char k = 'a'; k < 'a' + oddCount; k++)
                        {

                            Console.WriteLine($"{i}{j}{k}");
                            placeCounter++;

                        }
                    }
                    else
                    {

                        for (char k = 'a'; k < 'a' + evenCount; k++)
                        {

                            Console.WriteLine($"{i}{j}{k}");
                            placeCounter++;
                        }

                    }
                    
                }
                RowCount++;
            }

            Console.WriteLine(placeCounter);
        }
    }
}