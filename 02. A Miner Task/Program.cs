namespace _02._A_Miner_Task
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerNotes =
                new Dictionary<string, int>();

            string resource;

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!minerNotes.ContainsKey(resource))
                {
                    minerNotes.Add(resource, 0);
                }

                minerNotes[resource] += quantity;
            }

            foreach (KeyValuePair<string, int> resourceType in minerNotes)
            {
                Console.WriteLine($"{resourceType.Key} -> {resourceType.Value}");
            }
        }
    }
}