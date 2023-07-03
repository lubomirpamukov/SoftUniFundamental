namespace _03._Speed_Racing
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars= new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                double fuel = double.Parse(carData[1]);
                double fuelConsumption = double.Parse(carData[2]);

                Car currCar = new Car(model, fuel, fuelConsumption);
                cars.Add(currCar);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                 string model = cmdArgs[1];
                double distanceToTravel = double.Parse(cmdArgs[2]);

                Car car = cars.Find(c => c.Model == model);

                if (car != null) 
                {
                    car.TravelMetohd(distanceToTravel);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

    public class Car 
    {
        public Car(string model, double fuel, double fuelConsumption)
        {
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            TraveledDistance = 0;
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelConsumption { get; set; }

        public double TraveledDistance { get; set; }

        public void TravelMetohd(double distanceToTravel)
        {
            double fuelNeeded = FuelConsumption * distanceToTravel;

            if (Fuel >= fuelNeeded)
            {
                Fuel -= fuelNeeded;
                TraveledDistance += distanceToTravel;
            }
            else if (Fuel - (FuelConsumption * distanceToTravel) < 0) 
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {Fuel:f2} {TraveledDistance}";
        }
    }

   
}