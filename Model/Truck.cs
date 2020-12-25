namespace Model
{
    public class Truck : Vehicle
    {
         public Truck(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
             int fuelTankCapacity, double maxSpeed, double startSpeed)
         {
             VehicleBrand = vehicleBrand;
             Model = model;
             Fuel = fuel;
             FuelConsumption = fuelConsumption;
             FuelTankCapacity = fuelTankCapacity;
             MaxSpeed = maxSpeed;
             StartSpeed = startSpeed;

            Type = "Truck";
            QuantityOfDoors = 2;
            QuantityOfWheels = 6;
            QuantityOfPassengers = 3;
            Payload = 5000;
            Propeller = "Internal combustion engine";
            Purpose = "Shipping";
            Signalings = true;
            BrakingSystem = true;
            Headlights = true;
            Trailer = true;

            Refuel(fuelTankCapacity);
        }
    }
}
