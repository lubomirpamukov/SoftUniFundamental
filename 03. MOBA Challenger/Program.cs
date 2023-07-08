namespace _03._MOBA_Challenger
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerList =
                new Dictionary<string, Dictionary<string, int>>();

            string command;

            while ((command = Console.ReadLine()) != "Season end")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.TrimEntries);

                AddMethod(playerList, cmdArgs);
                DuelMethod(playerList, cmdArgs);
            }

            PrintMethod(playerList);
        }

        private static void PrintMethod(Dictionary<string, Dictionary<string, int>> playerList)
        {
            foreach (var player in playerList.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }

        private static void DuelMethod(Dictionary<string, Dictionary<string, int>> playerList, string[] cmdArgs)
        {
            if (cmdArgs[1] == "vs")
            {
                string firstPlayer = cmdArgs[0];
                string secondPlayer = cmdArgs[2];

                var compare = playerList.ContainsKey(firstPlayer) && playerList.ContainsKey(secondPlayer)
                    ? playerList[firstPlayer].Keys.Intersect(playerList[secondPlayer].Keys).Any()
                    : false;

                if (compare)
                {
                    int playerOne = playerList[firstPlayer].Values.Sum();
                    int playerTwo = playerList[secondPlayer].Values.Sum();

                    if (playerOne > playerTwo)
                    {
                        playerList.Remove(secondPlayer);
                    }
                    else if (playerOne < playerTwo)
                    {
                        playerList.Remove(firstPlayer);
                    }
                }
            }
        }

        private static void AddMethod(Dictionary<string, Dictionary<string, int>> playerList, string[] cmdArgs)
        {
            if (cmdArgs[1] == "->")
            {
                string playerName = cmdArgs[0];
                string role = cmdArgs[2];
                int skill = int.Parse(cmdArgs[4]);

                if (!playerList.ContainsKey(playerName))
                {
                    playerList[playerName] = new Dictionary<string, int>();
                }

                if (!playerList[playerName].ContainsKey(role))
                {
                    playerList[playerName][role] = 0;
                }

                if (playerList[playerName][role] < skill)
                {
                    playerList[playerName][role] = skill;
                }
               

            }
        }
    }
}