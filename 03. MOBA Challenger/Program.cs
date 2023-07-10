namespace _03._MOBA_Challenger
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerList = //creating dictionary
                new Dictionary<string, Dictionary<string, int>>();

            string command = string.Empty; // initialize string

            while ((command = Console.ReadLine()) != "Season end") // while loop that iterates until input season end
            {
                string[] cmdArgs = command // variable that breaks input into array to extract data
                    .Split(" ", StringSplitOptions.TrimEntries);// splits by white space

                AddMethod(playerList, cmdArgs); // custum method that adds players their roles and skill points for the role
                DuelMethod(playerList, cmdArgs);// method that checks if the player exist and play roles
                                                // that intercents,if yes they duel and the player with less overall
                                                // skill points loses and leaves the tournament
            }

            PrintMethod(playerList); // prints all the players ordered
        }

        private static void PrintMethod(Dictionary<string, Dictionary<string, int>> playerList)
        {
            foreach (var player in playerList.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))// orders the player by skill and then by name
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill"); // prints the name of the player and total skill points

                foreach (var position in player.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))// prints every role of the player ordered by skill points and then by name
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");// prints role and the skills of the player in the current role
                }
            }
        }

        private static void DuelMethod(Dictionary<string, Dictionary<string, int>> playerList, string[] cmdArgs)
        {
            if (cmdArgs[1] == "vs") // vs means 2 players will duel
            {
                string firstPlayer = cmdArgs[0]; // taking the first player name
                string secondPlayer = cmdArgs[2]; // taking the secound player name

                var compare = playerList.ContainsKey(firstPlayer) && playerList.ContainsKey(secondPlayer) // checks if the 2 players exist in the list
                    ? playerList[firstPlayer].Keys.Intersect(playerList[secondPlayer].Keys).Any()// checks if they have roles that intersect
                    : false; // if they dont returns false

                if (compare) // if compare = true means the players can duel
                {
                    int playerOne = playerList[firstPlayer].Values.Sum(); // taking first player all role skill points and sums them together
                    int playerTwo = playerList[secondPlayer].Values.Sum(); // taking secondPlayer all role skill points and sums them together

                    if (playerOne > playerTwo) // check who player have higher points
                    {
                        playerList.Remove(secondPlayer); // remove the weaker player from the tournament 
                    }
                    else if (playerOne < playerTwo)// check who player have higher points
                    {
                        playerList.Remove(firstPlayer); //remove the weaker player from the tournament
                    }
                }
            }
        }

        private static void AddMethod(Dictionary<string, Dictionary<string, int>> playerList, string[] cmdArgs)
            //making method that takes dictionary<string, dict<string,int>> 
        {
            if (cmdArgs[1] == "->") // if "->" means that we need to add player
            {
                string playerName = cmdArgs[0]; // creating variable for easy readability
                string role = cmdArgs[2]; //creating variable for easy readability
                int skill = int.Parse(cmdArgs[4]); // parsing to int to use the points for calculations in the future

                if (!playerList.ContainsKey(playerName)) // if player is not in the list
                {
                    playerList[playerName] = new Dictionary<string, int>();// creating the player(Key) and empty value =>dict(str,int)
                }

                if (!playerList[playerName].ContainsKey(role))//checks if the player in the list have role if not
                {
                    playerList[playerName][role] = 0; // adds the role(key) and 0 for (value)
                }

                if (playerList[playerName][role] < skill) // if skills is bigger than role(value)
                {
                    playerList[playerName][role] = skill; // makes the role(value) == to the skill points
                }
               

            }
        }
    }
}