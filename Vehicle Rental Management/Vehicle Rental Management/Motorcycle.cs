using System;

public class Motorcycle : Vehicle
{
    // Additional properties specific to Motorcycle
    private int engineCapacity;
    private string fuelType;
    private bool hasFairing;

    // Get and Set methods for additional properties
    public int EngineCapacity
    {
        get { return engineCapacity; }
        set { engineCapacity = value; }
    }

    public string FuelType
    {
        get { return fuelType; }
        set { fuelType = value; }
    }

    public bool HasFairing
    {
        get { return hasFairing; }
        set { hasFairing = value; }
    }

    // Override DisplayDetails method to include motorcycle-specific details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}cc, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
    }
}
