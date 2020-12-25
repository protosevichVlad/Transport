namespace Model
{
    public class Tank: Vehicle
    {
        public Tank(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
            int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "Tank";
            QuantityOfDoors = 3;
            QuantityOfWheels = 2;
            QuantityOfPassengers = 3;
            Payload = 1000;
            Propeller = "Internal combustion engine";
            Purpose = "Military";
            Headlights = true;

            Refuel(fuelTankCapacity);
        }
    }
}
