using System;
using System.Collections.Generic;

public class RentalAgency
{
    // Properties
    private List<Vehicle> fleet;
    private double totalRevenue;

    // Constructor
    public RentalAgency()
    {
        fleet = new List<Vehicle>();
        totalRevenue = 0.0;
    }

    // Property for TotalRevenue
    public double TotalRevenue
    {
        get { return totalRevenue; }
        private set { totalRevenue = value; }
    }

    // Method to add a vehicle to the fleet
    public void AddVehicle(Vehicle vehicle)
    {
        fleet.Add(vehicle);
        Console.WriteLine("Vehicle added to the fleet.");
    }

    // Method to remove a vehicle from the fleet
    public void RemoveVehicle(Vehicle vehicle)
    {
        if (fleet.Remove(vehicle))
        {
            Console.WriteLine("Vehicle removed from the fleet.");
        }
        else
        {
            Console.WriteLine("Vehicle not found in the fleet.");
        }
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle)
    {
        if (fleet.Contains(vehicle))
        {
            fleet.Remove(vehicle);
            totalRevenue += vehicle.RentalPrice;
            Console.WriteLine("Vehicle rented successfully.");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }

    // Method to display all vehicles in the fleet
    public void DisplayFleet()
    {
        if (fleet.Count == 0)
        {
            Console.WriteLine("No vehicles in the fleet.");
        }
        else
        {
            foreach (Vehicle vehicle in fleet)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}
