namespace Model
{
    public class Trolleybus : Vehicle
    {
        public Trolleybus(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
            int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "Trolleybus";
            QuantityOfDoors = 3;
            QuantityOfWheels = 4;
            QuantityOfPassengers = 25;
            Payload = 2000;
            Propeller = "Electromotor";
            Purpose = "Public";
            Signalings = true;
            BrakingSystem = true;
            Headlights = true;
            Trailer = true;

            Refuel(fuelTankCapacity);
        }
    }
}
