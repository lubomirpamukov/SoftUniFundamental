namespace _04._SoftUni_Parking
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingList = // creating dictionary for parked cars
                new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine()); // number of parked cars

            for (int i = 0; i < n; i++) // loop that iterates for each car
            {
                string[] cmdArgs = Console.ReadLine() // spliting input into array to extract data
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = cmdArgs[0]; // renaming varaibles for easy readability
                string username = cmdArgs[1]; // renaming variables for easy readability

                if (commandType == "register") // tries to register a vehicle
                {
                    string carPlate = cmdArgs[2]; // vehicle carPlate
                    RegisterVehicle(parkingList, username, carPlate); // custom metod that checks if vehicle alredy exist
                }
                else if (commandType == "unregister")  // tries to unregister vehicle
                {
                    UnRegisterVehicle(parkingList, username); // custom method that checks if vehicle is registred and unregister it
                }
            }
            PrintParkingList(parkingList); // printing final parking list
        }

        public static void RegisterVehicle(Dictionary<string, string> parkingList, string username, string carPlate) 
        {
            if (!parkingList.ContainsKey(username)) // checks if vehicle is not in the parking list
            {
                parkingList[username] = carPlate; // register vehicle 
                Console.WriteLine($"{username} registered {carPlate} successfully"); // print confirmation notification
            }
            else 
            {
                Console.WriteLine($"ERROR: already registered with plate number {parkingList[username]}");// print decline notification
            }
        }

        public static void UnRegisterVehicle(Dictionary<string, string> parkingList, string username) 
        {
            if (!parkingList.ContainsKey(username)) // checks if there is NOT a user registered in hte parking list
            {
                Console.WriteLine($"ERROR: user {username} not found"); // print notification 
            }
            else 
            {
                Console.WriteLine($"{username} unregistered successfully"); // print notification 
                parkingList.Remove(username); // unregister vehicle 
            }
        }

        public static void PrintParkingList(Dictionary<string, string> parkingList) 
        {
            foreach (KeyValuePair<string,string> user in parkingList) // iterates through every key value pair and prints its key and value
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}