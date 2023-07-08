namespace _03._Orders
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> productList = // creates dictionary
                new Dictionary<string, List<double>>();

            string command; // initialize empty string

            while ((command = Console.ReadLine()) != "buy") // making loops that iteretes until "buy" command 
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries); // making string array to extract data from the input
                string name = cmdArgs[0]; // rewrite the data into variables with better names for easy readability 
                double price = double.Parse(cmdArgs[1]);// rewrite the data into variables with better names for easy readability 
                double qunatity = double.Parse(cmdArgs[2]); // rewrite the data into variables with better names for easy readability 

                if (!productList.ContainsKey(name)) // checks if the product is not in the dictionary
                {
                    productList.Add(name,new List<double>()); // adds the name and initialize empty list
                    productList[name].Add(0); // initialize 0 as placeholder
                    productList[name].Add(0); // initialize 0 as place holder
                }

                if (productList[name][0] != price) // check if the price is the same as the old one
                {
                    productList[name][0] = price; // if its not writes the new price
                    productList[name][1] += qunatity; // adds quantity
                }
                else 
                {
                    productList[name][1] += qunatity; // adds quantity of the product
                }
            }

            foreach (var product in productList) // iterates through every product in the productList
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}"); // prints the product and the total price of the product
            }
        }
    }
}