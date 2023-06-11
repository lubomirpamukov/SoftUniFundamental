namespace _12._The_song_of_the_wheels
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int passwordCounter = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            


            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int forth = 1; forth <= 9; forth++)
                        {
                            if (first < second && third > forth && (first*second) + (third*forth) == number)
                            {
                                
                                Console.Write(" "+first+second+third+forth);
                                passwordCounter++;

                                if (passwordCounter == 4)
                                { 
                                    p1= first;
                                    p2= second;
                                    p3 = third;
                                    p4 = forth;
                                
                                }
                                    
                            }
                        }
                    }
                }
            }

            if (p1 == 0)
            {
                Console.WriteLine("No!");
            }
            else if (p1 != 0)
            {
                Console.WriteLine("\nPassword:" + " " + p1+p2+p3+p4);
            }
        }
    }
}