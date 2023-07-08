namespace _02._Judge
{
     using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestList = //creating new dictionary
                new Dictionary<string, Dictionary<string, int>>();
            string command;

            while ((command = Console.ReadLine()) != "no more time") // loop that iterates until "no more time" is given
            {
                string[] cmdArgs = command // creating string array to extract data
                    .Split("->", StringSplitOptions.TrimEntries); // split the input by "->"
                string username = cmdArgs[0];// creating new variables with better name for easy readability
                string contest = cmdArgs[1];// creating new variables with better name for easy readability
                int points = int.Parse(cmdArgs[2]);// creating new variables with better name for easy readability

                if (!contestList.ContainsKey(contest)) // check if there is a contest in the dictionary with that name
                {
                    contestList[contest] = new Dictionary<string, int>(); // if NOT creating contest with that name and assinging as VAlue a new dictionary
                }

                if (!contestList[contest].ContainsKey(username)) // checking if in the contestList dictionary there is a contest that contains username input
                {
                    contestList[contest][username] = points; // if NOT adding the username and initializing Value for him 0 as points
                }
                else if (contestList[contest][username] < points) // checking if the username points are bigger than previous participations 
                {
                    contestList[contest][username] = points;// if yes write the higher points for the username
                }
            }


            foreach (var contest in contestList) // loop that iterates through every contest in contestList
            {
                int counter = 1;// counter to give them placing in the ranking
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants"); // print the contest name and the participants count

                // foreach loop that iterates through every student in a contest ordering them in descending by their points, then alphabeticaly by name
                foreach (var student in contest.Value.OrderByDescending(student => student.Value).ThenBy(student => student.Key))
                {
                    Console.WriteLine($"{counter}. {student.Key} <::> {student.Value}"); // print student name and student points
                    counter++; // adds 1 to the counter
                }
            }

            Console.WriteLine("Individual standings:");
            int individualPosition = 1; // counter
            //foreach loop that orders individual contestatnts
            foreach (var participant in contestList
                .SelectMany(c => c.Value) // selects all the constets values (dictionary of student + points)
                .GroupBy(p => p.Key)// groups all of the student contests
                .OrderByDescending(g => g.Sum(p => p.Value)) // order desending by group sum
                .ThenBy(g => g.Key))// then alphabetically by name if there 2 students with same score
            {
                Console.WriteLine($"{individualPosition}. {participant.Key} -> {participant.Sum(p => p.Value)}"); // prints student position, name, and calculates all their points
                individualPosition++;
            }

        }
    }
}