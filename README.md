# Vehicle Rental Management System

## Overview

The Vehicle Rental Management System is a console-based application designed to manage a fleet of rental vehicles. It demonstrates the use of object-oriented principles such as inheritance, encapsulation, and abstraction. The application allows users to add, remove, rent vehicles, and display the fleet and total revenue generated from rentals.

## Features

- **Add Vehicle**: Add new vehicles to the fleet.
- **Remove Vehicle**: Remove vehicles from the fleet.
- **Rent Vehicle**: Rent out vehicles to customers.
- **Display Fleet**: View the current list of vehicles available for rent.
- **Display Total Revenue**: View the total revenue generated from rented vehicles.

## Class Structure

### 1. Vehicle Class (`Vehicle.cs`)

- Represents a generic vehicle available for rental.
- Properties:
  - `Model`
  - `Manufacturer`
  - `Year`
  - `RentalPrice`
- Methods:
  - `DisplayDetails()`: Displays the vehicle's details.

### 2. Car Class (`Car.cs`)

- Inherits from the `Vehicle` class.
- Additional Properties:
  - `Seats`
  - `EngineType`
  - `Transmission`
  - `Convertible`
- Methods:
  - Overrides `DisplayDetails()` to display car-specific details.

### 3. Truck Class (`Truck.cs`)

- Inherits from the `Vehicle` class.
- Additional Properties:
  - `Capacity`
  - `TruckType`
  - `FourWheelDrive`
- Methods:
  - Overrides `DisplayDetails()` to display truck-specific details.

### 4. Motorcycle Class (`Motorcycle.cs`)

- Inherits from the `Vehicle` class.
- Additional Properties:
  - `EngineCapacity`
  - `FuelType`
  - `HasFairing`
- Methods:
  - Overrides `DisplayDetails()` to display motorcycle-specific details.

### 5. RentalAgency Class (`RentalAgency.cs`)

- Manages the rental agency's fleet of vehicles.
- Properties:
  - `Fleet`: A list to store instances of vehicles.
  - `TotalRevenue`: Tracks the total revenue earned by the rental agency.
- Methods:
  - `AddVehicle()`: Adds a vehicle to the fleet.
  - `RemoveVehicle()`: Removes a vehicle from the fleet.
  - `RentVehicle()`: Rents out a vehicle.
  - `DisplayFleet()`: Displays all vehicles in the fleet.
  - `DisplayTotalRevenue()`: Displays the total revenue generated.

## Usage

### Running the Program

1. Compile and run the program.
2. You will see a menu with the following options:
   - Add Vehicle
   - Remove Vehicle
   - Rent Vehicle
   - Display Fleet
   - Display Total Revenue
   - Exit

### Default Vehicles

- The program starts with some default vehicles in the fleet:
  - Car: Tesla Model S
  - Truck: Ford F-150
  - Motorcycle: Kawasaki Ninja

### Adding a Vehicle

1. Select the `Add Vehicle` option.
2. Choose the type of vehicle to add (Car, Truck, Motorcycle).
3. Follow the prompts to enter the vehicle details.

### Removing a Vehicle

1. Select the `Remove Vehicle` option.
2. Enter the model of the vehicle you want to remove.

### Renting a Vehicle

1. Select the `Rent Vehicle` option.
2. Enter the model of the vehicle you want to rent.

### Displaying the Fleet

- Select the `Display Fleet` option to view all vehicles currently available for rent.

### Displaying Total Revenue

- Select the `Display Total Revenue` option to view the total revenue generated from rented vehicles.

## Conclusion

The Vehicle Rental Management System is a practical application demonstrating key object-oriented programming concepts. It is designed for ease of use and can be extended further with additional features and functionalities.

## Acknowledgements

- This project was developed as part of the PROG8051 course at Conestoga College.
