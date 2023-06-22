namespace _06._Store_Boxes
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        public class Item 
        {
            public Item(string itemName, decimal itemPrice)
            {
                ItemName = itemName;
                ItemPrice = itemPrice;
            }
    
            public string ItemName { get; private set; }

            public decimal ItemPrice { get; private set; } 
        }

        public class Box
        {
            public Box(string serialNumber, Item item, int itemQuantity)
            {
                SerialNumber = serialNumber;
                Item = item;
                ItemQuantity = itemQuantity;
            }

            public string SerialNumber { get; private set; }

            public Item Item { get; private set; }

            public int ItemQuantity { get; private set; }


            public decimal PricePerBox { get 
                { 
                    return ItemQuantity * Item.ItemPrice; 
                } 
            }
        }

        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] boxData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = boxData[0];
                string itemName = boxData[1];
                int itemQuantity = int.Parse(boxData[2]);
                decimal itemPrice  = decimal.Parse(boxData[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
        }
    }
}