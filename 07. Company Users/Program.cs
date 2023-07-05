namespace _07._Company_Users
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesList = // creating a dictionary
                new Dictionary<string, List<string>>();
            string command;

            while ((command = Console.ReadLine()) !="End") // while loop that iterates until the command end
            {
                string[] cmdArgs = command  // break command into array of strings to extract data
                    .Split("->", StringSplitOptions.TrimEntries);
                string company = cmdArgs[0]; // making company variable for easy readability 
                string employeeID = cmdArgs[1]; // making company variable for easy readability
                CompanyListManipulation(companiesList, company, employeeID); // custom method that manipulated the dictonary data
            }

            PrintCompanyData(companiesList); // custom print method that prints filtered dictionary
        }

        private static void CompanyListManipulation(Dictionary<string, List<string>> companiesList, string company, string employeeID)
        {
            if (!companiesList.ContainsKey(company)) // if companiesList dictionary DONT contain company
            {
                companiesList[company] = new List<string>(); // creates company in the dictionary
            }

            if (!companiesList[company].Contains(employeeID)) // checks if company DONT contain emloyee with that ID
            {
                companiesList[company].Add(employeeID); // adds employee ID
            }

        }

        private static void PrintCompanyData(Dictionary<string, List<string>> companiesList) // method that prints all the companys and there employee ID's
        {
            foreach (KeyValuePair<string, List<string>> curCompany in companiesList) // iterates thourgh all the companys
            {
                Console.WriteLine(curCompany.Key); // prints company name

                foreach (string ID in curCompany.Value) // iterates thourg all the employee ID's 
                {
                    Console.WriteLine($"-- {ID}"); // prints each employee ID
                }
            }
        }
    }
}