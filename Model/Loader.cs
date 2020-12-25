namespace Model
{
    public class Loader : Vehicle
    {
        public Loader(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
            int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "Loader";
            QuantityOfDoors = 1;
            QuantityOfWheels = 4;
            QuantityOfPassengers = 1;
            Payload = 1000;
            Propeller = "Internal combustion engine";
            Purpose = "Сonstruction machinery";
            Signalings = true;
            BrakingSystem = true;
            Headlights = true;
            Trailer = true;

            Refuel(fuelTankCapacity);
        }
    }
}
