namespace _03._Orders
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> productList =
                new Dictionary<string, List<double>>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                double qunatity = double.Parse(cmdArgs[2]);

                if (!productList.ContainsKey(name))
                {
                    productList.Add(name,new List<double>());
                    productList[name].Add(0);
                    productList[name].Add(0);
                }

                if (productList[name][0] != price)
                {
                    productList[name][0] = price;
                    productList[name][1] += qunatity;
                }
                else 
                {
                    productList[name][0] = price;
                    productList[name][1] += qunatity;
                }
            }

            foreach (var product in productList)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}