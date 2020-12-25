namespace Model
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
            int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "Motorcycle";
        QuantityOfWheels = 2;
        QuantityOfPassengers = 2;
        Payload = 200;
        Propeller = "Internal combustion engine";
        Purpose = "Personal";
        Signalings = true;
        BrakingSystem = true;
        Headlights = true;

        Refuel(fuelTankCapacity);
    }
}
}
