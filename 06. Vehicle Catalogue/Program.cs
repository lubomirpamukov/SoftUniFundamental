namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(); // creating list of Car instances
            List<Truck> trucks = new List<Truck>(); // creating list of truck instance

            string command;

            while ((command = Console.ReadLine()) != "End") // reading vehicle data from the console until command end is given
            {
                string[] vehicleInfo = command.Split(" ", StringSplitOptions.TrimEntries); // saving the vehicle data into array of string spliting it by white space and triming the empthy entries
                string type = vehicleInfo[0]; // saving the input into different variables for easier readability
                string model = vehicleInfo[1];// saving the input into different variables for easier readability
                string color = vehicleInfo[2];// saving the input into different variables for easier readability
                int horsePower = int.Parse(vehicleInfo[3]);// saving the input into different variables for easier readability

                if (type == "car") // if type is car
                {
                    Car car = new Car(model, color, horsePower); //creating object of a car with the given vehicle data
                    cars.Add(car); // adding the vehicle to the cars list
                }
                else if (type == "truck") // if truck
                {
                    Truck truck = new Truck(model, color, horsePower); // creating object with the given data
                    trucks.Add(truck); // adding the vehilce  to the trucj list
                }
            }

            string vehicleBrand; // reading vehicle brand from the console

            while ((vehicleBrand = Console.ReadLine()) != "Close the Catalogue") // searching for the given vehlice data until close calaog input is given
            {
                Car car = cars.FirstOrDefault(c => c.Model == vehicleBrand); // searching for the vehicleBrand in the cars list , if it dosnt exist it will return the default value of the object which is null
                Truck truck = trucks.FirstOrDefault(t => t.Model == vehicleBrand);// searching for the vehicleBrand in the cars list, if it doesnt exist it will return the default value of the object which is null

                if (car != null) // if cars is differen than null it means that object exist with that vrand in the list and the other object properties are printed
                {
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Color: {car.Color}");
                    Console.WriteLine($"Horsepower: {car.HorsePower}");
                }
                else if (truck != null) // if trucks is differen than null it means that object exist with that vrand in the list and the other object properties are printed
                {
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {truck.Model}");
                    Console.WriteLine($"Color: {truck.Color}");
                    Console.WriteLine($"Horsepower: {truck.HorsePower}");
                }

               
            }
            
            double carsAvgHp = cars.Any() ? cars.Average(c => c.HorsePower) : 0; // here 1) we make variable to store the data, 2) cars.Any() checks if there are items in the list, 3) ternal operator ? gives a default value of 0 if there arnt any objects in the list, cars.Avarge(c =>c.HorsePower) is a method that uses lamda to caluclate the avrage horse power in the list of cars
            double trucksAvgHp = trucks.Any() ? trucks.Average(t => t.HorsePower) : 0;// here 1) we make variable to store the data, 2) cars.Any() checks if there are items in the list, 3) ternal operator ? gives a default value of 0 if there arnt any objects in the list, cars.Avarge(c =>c.HorsePower) is a method that uses lamda to caluclate the avrage horse power in the list of cars

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHp:f2}."); // printing the avrages
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHp:f2}."); // printing the avrages
        }
    }

    public class Car // creates Car class
    {
        public Car(string model, string color, int horsePower) // creates Car class constructor
        {
            Model = model; // saves the input data to the property
            Color = color;// saves the input data to the property
            HorsePower = horsePower;// saves the input data to the property
        }

        public string Model { get; private set; } // Creating Property

        public string Color { get; private set; } // creating property

        public int HorsePower { get; private set; } //creating property

    }

    public class Truck // creating public class Truck
    {
        public Truck(string model, string color, int horsePower) // creating constructor for the class 
        {
            Model = model;// Creating Property
            Color = color;// Creating Property
            HorsePower = horsePower;// Creating Property
        }
        public string Model { get; private set; }//creating property

        public string Color { get; private set; //creating property

        public int HorsePower { get; private set; //creating property
        }
   
}