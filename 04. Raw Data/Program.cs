namespace _04._Raw_Data
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(); //iniatilize list of car objects
            int numberOfCars = int.Parse(Console.ReadLine()); // taking the number of cars that will be added in the list

            for (int i = 0; i < numberOfCars; i++) // loop to fill the list of cars
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);// taking the data from the console
                string model = carData[0]; // rewriting the data into variables with clearer name for easy readability
                int engineSpeed = int.Parse(carData[1]);// rewriting the data into variables with clearer name for easy readability
                int enginePower = int.Parse(carData[2]);// rewriting the data into variables with clearer name for easy readability
                int cargoWeight = int.Parse(carData[3]);// rewriting the data into variables with clearer name for easy readability
                string cargoType = carData[4];// rewriting the data into variables with clearer name for easy readability

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType); // making an object with the given data
                cars.Add(car); // adding the object to the list
            }

            string command = Console.ReadLine(); // making a string command

            if (command == "fragile") // if fragile
            {
                List<Car> fragileCargo = cars.Where(c => c.Cargo.CargoType == "fragile" && c.Cargo.CargoWeigth < 1000).ToList(); // making fragileCargo list that filters all the cars with fragile cargo that is under 1000 kg

                foreach (Car car in fragileCargo)  // prining all the car models in the filtered list
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")  // if cargo is flamable
            {
                List<Car> flamableCars = cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250).ToList();// making flamableCargo list that filters all the cars with fragile cargo , and engline power  > 250 hp

                foreach (Car car in flamableCars) // printing all the cars in the flamabe list
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }

    class Car // declaring class Car
    {
        
        public Car(string model, int engineSpeed, int enginePower, int cargoWeigth , string cargoType) // constructor for the Car class with all the needed data, for initializing the Engine class and Cargo class inside
        {
            this.Model = model; 
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo (cargoWeigth, cargoType);
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }

    class Cargo // declaring Cargo class
    {
        public Cargo(int cargoWeigth, string cargoType) // making constructor for the class
        {
            this.CargoWeigth = cargoWeigth;
            this.CargoType = cargoType;
        }

        public int CargoWeigth { get; set; }

        public string CargoType { get; set; }
    }

    class Engine  // declaring Engine  class
    {
        public Engine(int engineSpeed, int enginePower) // making constructor for the engine class
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }

        public int EnginePower { get; set;}
    }
}