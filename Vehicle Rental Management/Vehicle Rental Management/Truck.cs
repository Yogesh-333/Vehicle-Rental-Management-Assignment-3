using System;

public class Truck : Vehicle
{
    // Additional properties specific to Truck
    private double capacity;
    private string truckType;
    private bool fourWheelDrive;

    // Get and Set methods for additional properties
    public double Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public string TruckType
    {
        get { return truckType; }
        set { truckType = value; }
    }

    public bool FourWheelDrive
    {
        get { return fourWheelDrive; }
        set { fourWheelDrive = value; }
    }

    // Override DisplayDetails method to include truck-specific details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity}, Truck Type: {TruckType}, Four-Wheel Drive: {FourWheelDrive}");
    }
}
