namespace Model
{
    public class Bus : Vehicle
    {
        public Bus(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
            int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "Bus";
            QuantityOfDoors = 3;
            QuantityOfWheels = 4;
            QuantityOfPassengers = 25;
            Payload = 2000;
            Propeller = "Internal combustion engine";
            Purpose = "Public";
            Signalings = true;
            BrakingSystem = true;
            Headlights = true;
            Trailer = true;

            Refuel(fuelTankCapacity);
        }
    }
}
