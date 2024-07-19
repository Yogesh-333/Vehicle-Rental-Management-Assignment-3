public class Program
{
    public static void Main()
    {
        RentalAgency rentalAgency = new RentalAgency();

        // Creating vehicles
        Car car = new Car { Model = "Model S", Manufacturer = "Tesla", Year = 2020, RentalPrice = 100.0, Seats = 5, EngineType = "Electric", Transmission = "Automatic", Convertible = false };
        Truck truck = new Truck { Model = "F-150", Manufacturer = "Ford", Year = 2018, RentalPrice = 80.0, Capacity = 2000, TruckType = "Pickup", FourWheelDrive = true };
        Motorcycle motorcycle = new Motorcycle { Model = "Ninja", Manufacturer = "Kawasaki", Year = 2019, RentalPrice = 50.0, EngineCapacity = 600, FuelType = "Petrol", HasFairing = true };

        // Adding vehicles to the fleet
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        // Displaying fleet
        Console.WriteLine("Fleet:");
        rentalAgency.DisplayFleet();

        // Renting a vehicle
        rentalAgency.RentVehicle(car);
        Console.WriteLine("Fleet after renting a car:");
        rentalAgency.DisplayFleet();

        // Displaying total revenue
        Console.WriteLine($"Total Revenue: ${rentalAgency.TotalRevenue}");
    }
}
