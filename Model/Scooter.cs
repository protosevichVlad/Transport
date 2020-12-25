namespace Model
{
    public class Scooter: Vehicle
    {
        public Scooter(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "Scooter";
            QuantityOfWheels = 2;
            QuantityOfPassengers = 1;
            Payload = 60;
            Propeller = "Human";
            Purpose = "Personal";

            Refuel(fuelTankCapacity);
        }
    }
}
