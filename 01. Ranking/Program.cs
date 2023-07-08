namespace _01._Ranking
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>(); // creating a dictionary

            string input; 
            input = AddContests(contests); // custom method that adds contests into the dictionary

            input = AddContestantsToTheContests(contests, users); // custom method that adds ontestants in the dictionary

            var bestUser = users // KeyValuePair that search for the bestUser
                .OrderByDescending(u => u.Value.Values.Sum()) // orders the dictionary by the points
                .FirstOrDefault(); // returns first user which will have the highest points
            if (bestUser.Key != null)
            {
                 Console.WriteLine($"Best candidate is {bestUser.Key} with total {bestUser.Value.Values.Sum()} points."); // prints the best user
            }

            Console.WriteLine("Ranking:"); // prints ranking
            foreach (var user in users.OrderBy(u => u.Key)) // foreach that orders user alphabeticaly
            {
                Console.WriteLine(user.Key); // print user name
                foreach (var contest in user.Value.OrderByDescending(c => c.Value)) // foreach that orders the contest decending by points
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}"); // prints contest and points for the contest
                }
            }
        }

        private static string AddContestantsToTheContests(Dictionary<string, string> contests, Dictionary<string, Dictionary<string, int>> users)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of submissions") // adds users to the contests
            {
                string[] submissionArgs = input.Split("=>"); // splits the input 
                string contest = submissionArgs[0]; // extract contest 
                string password = submissionArgs[1]; // extract password for the contest
                string username = submissionArgs[2]; // extract user name
                int points = int.Parse(submissionArgs[3]); // extract points

                if (contests.ContainsKey(contest) && contests[contest] == password) //if the contest exist and the password match the user is registered
                {
                    if (!users.ContainsKey(username)) // if that user dont exist in the contest
                    {
                        users[username] = new Dictionary<string, int>(); // user is registered and a dictionary is initialized
                    }

                    if (!users[username].ContainsKey(contest)) // if user isnt alredy registered in that contest
                    {
                        users[username][contest] = 0; // registres the user for the contest and giv him 0 points
                    }

                    if (points > users[username][contest]) // if the user have higher points than the last time he compete 
                    {
                        users[username][contest] = points; // higher points are added as his new points
                    }
                }
            }

            return input; // returns the changed dictinary
        }

        private static string AddContests(Dictionary<string, string> contests) // custom method that adds contests
        {
            string input;
            while ((input = Console.ReadLine()) != "end of contests") // loop that iterates until "end of contest" input
            {
                string[] contestArgs = input.Split(':'); // split the input to extract data
                string contest = contestArgs[0]; // rewrite data with more appropriate variables for easy readability
                string password = contestArgs[1];// rewrite data with more appropriate variables for easy readability

                contests[contest] = password; // write the contests into the dictionary
            }

            return input; // returns the dictionary
        }
    }
}