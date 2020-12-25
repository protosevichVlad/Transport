namespace Model
{
    class Ufo: Vehicle
    {
        public Ufo(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
            int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;
            Type = "UFO";

            Refuel(fuelTankCapacity);
        }
    }
}
