using System;

public class Vehicle
{
    // Properties
    private string model;
    private string manufacturer;
    private int year;
    private double rentalPrice;

    // Get and Set methods for properties
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public double RentalPrice
    {
        get { return rentalPrice; }
        set { rentalPrice = value; }
    }

    // Method to display vehicle details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: ${RentalPrice}");
    }
}
