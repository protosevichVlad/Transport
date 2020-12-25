namespace Model
{
    public static class FactoryVehicles
    {
        public static Vehicle CreateVehicle(string type, string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapacity, double maxSpeed, double startSpeed)
        {
            if (type == "Car")
            {
                return new Car(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Scooter")
            {
                return new Scooter(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Truck")
            {
                return new Truck(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Loader")
            {
                return new Loader(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Bus")
            {
                return new Bus(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Trolleybus")
            {
                return new Trolleybus(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Tram")
            {
                return new Tram(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Motorcycle")
            {
                return new Motorcycle(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "HorseDrawnCarriage")
            {
                return new HorseDrawnCarriage(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Bicycle")
            {
                return new Bicycle(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            if (type == "Tank")
            {
                return new Tank(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
            }

            return new Ufo(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapacity, maxSpeed, startSpeed);
        }
    }
}
