namespace _07._Safe_Passwords_Generator
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int aInt = int.Parse(Console.ReadLine())+35;
            int bInt = int.Parse(Console.ReadLine())+ 64;
            int end = int.Parse(Console.ReadLine());
            int counter = 1;

            char a = (char)aInt;
            char b= (char)bInt;

            for (char A = '#' ; A <= a; A++)
            {
                if (A > (char)55)
                {
                    A = (char)35;
                }
                for (char B = '@'; B <= b; B++)
                {
                    if (B > (char)96)
                    {
                        B = (char)64;
                    }

                    for (int x = 1; x <= aInt -35; x++)
                    {
                        for (int y = 1; y <= bInt - 64; y++)
                        {
                            
                            
                                if (counter > end)
                                {
                                    break;
                                }
                                    Console.Write($"{A}{B}{x}{y}{B}{A}|");
                                    A++;
                                    B++;
                                    y++;         
                                    x++;
                                    counter++;

                                
                                
                                    
                            


                        }
                    }
                }
            }


        }
    }
}