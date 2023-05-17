namespace _10.Pokemon
{
    using System;
        
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenPoke = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCounter = 0;
            double pokePowerCopy = pokePower / 2.0;

            //logic
            while (distanceBetweenPoke <= pokePower)
            {
                pokePower -= distanceBetweenPoke;
                pokeCounter++;

                if (pokePower == pokePowerCopy)
                {
                   
                    
                        if (pokePower / exhaustionFactor > 0)
                        {
                            pokePower /= exhaustionFactor;
                        }
                    
                }
            }
            //output
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);
        }
    }
}