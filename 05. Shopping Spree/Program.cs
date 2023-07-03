namespace _05._Shopping_Spree
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people= new List<Person>();
            List<Product>products= new List<Product>();

            string[] peopleInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < peopleInfo.Length; j++)
                {
                    string[] peopleData = peopleInfo[j].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = peopleData[0];
                    decimal money = decimal.Parse(peopleData[1]);
                    Person person = new Person(name, money);
                    people.Add(person);
                }


            string[] productInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < productInfo.Length; j++)
                {
                    string[] productData = productInfo[j].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string productName = productData[0];
                    decimal productPrice = decimal.Parse(productData[1]);
                    Product prodcut= new Product(productName, productPrice);
                    products.Add(prodcut);
                }
            

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = cmdArgs[0];
                string productName = cmdArgs[1];
                Person currPerson = people.FirstOrDefault(p => p.Name == personName);
                Product currProduct = products.FirstOrDefault(p => p.ProductName == productName);

                if (currPerson != null && currProduct != null)
                {
                    currPerson.BuyProduct(currProduct.Price, currProduct.ProductName);
                }
            }

            foreach (Person person in people)
            {
                if (person.BagOfProducts.Count <= 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else 
                {
                    Console.Write(person.Name + " - ");
                    string productsBought = string.Join(", ", person.BagOfProducts.Select(p => p.ProductName));
                    Console.WriteLine(productsBought);

                }

            }
        }

        public class Person 
        {
            public Person(string name, decimal money)
            {
                this.Name = name;
                this.Money = money;
                this.BagOfProducts = new List<Product>();
               

            }
            public List<Product> BagOfProducts { get; set; }

            public string Name { get; set; }

            public decimal Money { get; set; }

            public void BuyProduct (decimal productPrice, string productName)
            {
                if (productPrice > this.Money)
                {
                    Console.WriteLine($"{this.Name} can't afford {productName}");
                }
                else if (productPrice <= this.Money)
                {
                    this.Money -= productPrice;
                    Product newPorduct = new Product(productName, productPrice);
                    BagOfProducts.Add(newPorduct);
                    Console.WriteLine($"{this.Name} bought {productName}");

                }
            }
        }

        public class Product 
        {
            public Product(string productName, decimal productPrice)
            {
                this.ProductName = productName;
                this.Price = productPrice;
            }

            public string ProductName { get; set; }

            public decimal Price { get; set; }
          
        }
    }
}