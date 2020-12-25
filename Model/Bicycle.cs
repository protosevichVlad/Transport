namespace Model
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "Bicycle";
            QuantityOfWheels = 2;
            QuantityOfPassengers = 1;
            Payload = 80;
            Propeller = "Human";
            Purpose = "Personal";

            Refuel(fuelTankCapacity);
        }
    }
}
