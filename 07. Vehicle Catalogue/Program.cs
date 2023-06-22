namespace _07._Vehicle_Catalogue
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        public class Catalog 
        {
            public Catalog(Car car, Truck truck)  // creating class that contains other objects as data
            {
                this.Car = car; // making a constructor for the car property
                this.Truck = truck; // making a constructor that saves the data in the Truck property
            }
            public Car Car { get; set; } // making car property that has a public get and set 
            public Truck Truck { get; set; } // making a truck property that has a public get and set

        }

        public class Car // declaring a public class Car
        {
            public Car(string brand, string model, int horsePower) // making a constructor for the car class containing brand, model, horsepower
            {
                this.Brand = brand; // making a constructor that saves the brand data into the brand property
                this.Model = model; // making a constructor that saves the model data in the model property
                this.HoursePower = horsePower; // making a constructor that saves the horsepower data in the horsepower property
            }
            public string Brand { get; private set; } // making a property for the brand with a privet set that means it cant be changed outside of the class

            public string Model { get; private set; }// making a property for the model with a public get and a privet set, so it cant be changed outside the cladd

            public int HoursePower { get; private set; }// making property for the horsepower 
        
        }

        public class Truck // making a truck class
        {
            public Truck(string brand, string model, int weigth)// making a truck class constructor
            {
                this.Brand = brand; // saving data from the given input to the property of the class
                this.Model = model;// saving data from the given input to the property of the class
                this.Weight = weigth;// saving data from the given input to the property of the class

            }
            public string Brand { get; private set; }// making a property for the class

            public string Model { get; private set; } // making a property for the class

            public int Weight { get; private set; }// making a property for the class
        }
        static void Main(string[] args) // main method
        {
            List<Catalog> catalog = new List<Catalog>(); // making a list for the catalog class

            string input;

            while ((input = Console.ReadLine()) != "end") // reading input from the console until the command end
            {
                string[] vehicleData = input.Split("/", StringSplitOptions.RemoveEmptyEntries); // splitting the input into array to get the data

                string type = vehicleData[0];// taking data for type of vehicle
                string brand = vehicleData[1]; // taking data for brand of vehicle
                string model = vehicleData[2];// taking data for model of vehicle
                int value = int.Parse(vehicleData[3]); // taking data for horsepower/weigth of vehicle

                if (type == "Car") // if vehicle is a car
                {
                    Car car = new Car(brand, model, value); // making a new car object
                    catalog.Add(new Catalog(car, null)); // adding the car objecto to the catalog list
                }
                else if(type == "Truck") // if vehicle is truck
                {
                    Truck truck = new Truck(brand, model, value); // making a new truck object
                    catalog.Add(new Catalog(null, truck)); // adding the truck objecto to the catalog
                }
            }

            List<Car> sortedCars = catalog //making a new list
            .Where(c => c.Car != null) // Filter out the non-car items
            .OrderBy(c => c.Car.Brand) // orders car by brand name alphabeticaly
            .Select(c => c.Car) // extracts only the cars property from each item, creating a new sequence into sorted cars list
            .ToList();

            if (sortedCars != null) // if car is not null 
            {
                Console.WriteLine("Cars:"); // prints cars

                foreach (Car car in sortedCars) // prints all the items in the sorted list
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
                }
            }
            
            List<Truck> sortedTrucks = catalog // making a truck list
                .Where(t => t.Truck != null) // filters out non truck items
                .OrderBy(t => t.Truck.Brand) // orders the truck items by brand name alphabetically
                .Select(t => t.Truck) // extracts only trucks property from each item, creating a new sequence into sorted cars list
                .ToList();

            if (sortedTrucks != null) // if truck is not null
            {
                Console.WriteLine("Trucks:"); // prints all trucks

                foreach (Truck truck in sortedTrucks)// prints all the sorted trucks in the list
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}