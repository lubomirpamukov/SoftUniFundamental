namespace _11.Snowballs
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());


            BigInteger alphaSnowball = BigInteger.MinusOne;
            int alphaSnowballTime= 0;
            int alphaSnowballSnow= 0;
            int alphaSnowballQuality= 0;


            for (int i = 0; i < snowballCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
               
                BigInteger snowBallScore = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality) ;
               
                if (snowBallScore > alphaSnowball)
                {
                    alphaSnowball = snowBallScore;
                    alphaSnowballQuality= snowballQuality;
                    alphaSnowballSnow=snowballSnow;
                    alphaSnowballTime=snowballTime;
                }
            }
                Console.WriteLine($"{alphaSnowballSnow} : {alphaSnowballTime} = {alphaSnowball} ({alphaSnowballQuality})");

        }
    }
}