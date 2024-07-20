using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        RentalAgency rentalAgency = new RentalAgency();

        // Adding default vehicles
        AddDefaultVehicles(rentalAgency);

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nVehicle Rental Management System");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. Remove Vehicle");
            Console.WriteLine("3. Rent Vehicle");
            Console.WriteLine("4. Display Fleet");
            Console.WriteLine("5. Display Total Revenue");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice = 0;

            try
            {
                 choice = Convert.ToInt32(Console.ReadLine());
            }catch(Exception e) 
            {
                Console.WriteLine("Invalid choice. Please try again.");
                
            }

            if (choice > 0) 
            switch (choice)
            {
                case 1:
                    AddVehicle(rentalAgency);
                    break;
                case 2:
                    RemoveVehicle(rentalAgency);
                    break;
                case 3:
                    RentVehicle(rentalAgency);
                    break;
                case 4:
                    rentalAgency.DisplayFleet();
                    break;
                case 5:
                    Console.WriteLine($"Total Revenue: ${rentalAgency.TotalRevenue}");
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void AddDefaultVehicles(RentalAgency rentalAgency)
    {
        Car car1 = new Car { Model = "Model S", Manufacturer = "Tesla", Year = 2020, RentalPrice = 150.00, Seats = 5, EngineType = "Electric", Transmission = "Automatic", Convertible = false };
        Truck truck1 = new Truck { Model = "F-150", Manufacturer = "Ford", Year = 2019, RentalPrice = 120.00, Capacity = 2.0, TruckType = "Pickup", FourWheelDrive = true };
        Motorcycle motorcycle1 = new Motorcycle { Model = "Ninja", Manufacturer = "Kawasaki", Year = 2018, RentalPrice = 80.00, EngineCapacity = 650, FuelType = "Gasoline", HasFairing = true };

        rentalAgency.AddVehicle(car1);
        rentalAgency.AddVehicle(truck1);
        rentalAgency.AddVehicle(motorcycle1);
    }

    private static void AddVehicle(RentalAgency rentalAgency)
    {
        Console.WriteLine("Select Vehicle Type:");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Truck");
        Console.WriteLine("3. Motorcycle");
        Console.Write("Enter your choice: ");

        int type = Convert.ToInt32(Console.ReadLine());
        Vehicle vehicle;

        switch (type)
        {
            case 1:
                vehicle = new Car();
                SetVehicleDetails(vehicle);
                SetCarDetails((Car)vehicle);
                break;
            case 2:
                vehicle = new Truck();
                SetVehicleDetails(vehicle);
                SetTruckDetails((Truck)vehicle);
                break;
            case 3:
                vehicle = new Motorcycle();
                SetVehicleDetails(vehicle);
                SetMotorcycleDetails((Motorcycle)vehicle);
                break;
            default:
                Console.WriteLine("Invalid vehicle type. Returning to main menu.");
                return;
        }

        rentalAgency.AddVehicle(vehicle);
    }

    private static void SetVehicleDetails(Vehicle vehicle)
    {
        Console.Write("Enter Model: ");
        vehicle.Model = Console.ReadLine();
        Console.Write("Enter Manufacturer: ");
        vehicle.Manufacturer = Console.ReadLine();
        Console.Write("Enter Year: ");
        vehicle.Year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Rental Price: ");
        vehicle.RentalPrice = Convert.ToDouble(Console.ReadLine());
    }

    private static void SetCarDetails(Car car)
    {
        Console.Write("Enter Seats: ");
        car.Seats = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Engine Type: ");
        car.EngineType = Console.ReadLine();
        Console.Write("Enter Transmission: ");
        car.Transmission = Console.ReadLine();
        Console.Write("Is Convertible (true/false): ");
        car.Convertible = Convert.ToBoolean(Console.ReadLine());
    }

    private static void SetTruckDetails(Truck truck)
    {
        Console.Write("Enter Capacity: ");
        truck.Capacity = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Truck Type: ");
        truck.TruckType = Console.ReadLine();
        Console.Write("Is Four-Wheel Drive (true/false): ");
        truck.FourWheelDrive = Convert.ToBoolean(Console.ReadLine());
    }

    private static void SetMotorcycleDetails(Motorcycle motorcycle)
    {
        Console.Write("Enter Engine Capacity (cc): ");
        motorcycle.EngineCapacity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Fuel Type: ");
        motorcycle.FuelType = Console.ReadLine();
        Console.Write("Has Fairing (true/false): ");
        motorcycle.HasFairing = Convert.ToBoolean(Console.ReadLine());
    }

    private static void RemoveVehicle(RentalAgency rentalAgency)
    {
        Console.Write("Enter Model of the vehicle to remove: ");
        string model = Console.ReadLine();
        Vehicle vehicleToRemove = rentalAgency.Fleet.Find(v => v.Model == model);

        if (vehicleToRemove != null)
        {
            rentalAgency.RemoveVehicle(vehicleToRemove);
        }
        else
        {
            Console.WriteLine("Vehicle not found in the fleet.");
        }
    }

    private static void RentVehicle(RentalAgency rentalAgency)
    {
        Console.Write("Enter Model of the vehicle to rent: ");
        string model = Console.ReadLine();
        Vehicle vehicleToRent = rentalAgency.Fleet.Find(v => v.Model == model);

        if (vehicleToRent != null)
        {
            rentalAgency.RentVehicle(vehicleToRent);
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }
}
