namespace Model
{
    public class HorseDrawnCarriage
        : Vehicle
    {
        public HorseDrawnCarriage(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
            int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpeed;

            Type = "HorseDrawnCarriage";
            QuantityOfWheels = 4;
            QuantityOfPassengers = 5;
            Payload = 300;
            Propeller = "Horse";
            Purpose = "Personal";

            Refuel(fuelTankCapacity);
        }
    }
}
