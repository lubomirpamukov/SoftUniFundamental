namespace _01._Advertisement_Message
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // reading number of random generated reviews

            Massage massage = new Massage(); // creating an instance of the massage class

            Random random = new Random(); // creating an instance of random class

            for (int i = 0; i < n; i++) // each itteration this loop will generate random massage
            {
                int phraseIndex = random.Next(0, massage.Phrases.Length); // generating random number and converting it to int for the phrases
                int eventIndex = random.Next(0, massage.Events.Length); // generating random number and converting it to int for the events
                int authorIndex = random.Next(0, massage.Authors.Length); // generating random number and converting it to int for the author
                int cityIndex = random.Next(0, massage.Cities.Length);// generating random number and converting it to int for the city

                Console.WriteLine($"{massage.Phrases[phraseIndex]} {massage.Events[eventIndex]} {massage.Authors[authorIndex]} - {massage.Cities[cityIndex]}");
                                    // massage => selects the class  // .Phrase => selects the wanted property of the object    // [index]- randomly generated number
            }
            
        }

        public class Massage // declaration of the class massage
        {
            public readonly string[] Phrases = //making a field with phrases that is public and readonly so it cant be change from outside
            {   // filling the string array with data phrases
                "Excellent product.",                     
                "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.",
                "I can't live without this product."
            };

            public readonly string[] Events = // making a field with events that is public and cant be changed from outside
            { // filling it with events data
                "Now I feel good.", "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.", "I feel great!"

            };

            public readonly string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" }; //making a field with authors that is public and readonly so it cant be changes from outside

            public readonly string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" }; // making a field with cities that is public and readonly so it cant be changed from outside

        }
    }
}