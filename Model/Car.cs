namespace Model
{
    public class Car: Vehicle
    {
        public Car(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
            int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "Car";
            QuantityOfDoors = 4;
            QuantityOfWheels = 4;
            QuantityOfPassengers = 5;
            Payload = 500;
            Propeller = "Internal combustion engine";
            Purpose = "Personal";
            Signalings = true;
            BrakingSystem = true;
            Headlights = true;
            Trailer = true;

            Refuel(fuelTankCapacity);
        }
    }
}
