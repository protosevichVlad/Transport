using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Model
{
    public static class FactoryVehicles
    {
        public static Vehicle CreateVehicle(string type, string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapasity, double maxSpeed, double startSpead)
        {
            if (type == "Car")
            {
                return new Car(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Scooter")
            {
                return new Scooter(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Truck")
            {
                return new Truck(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Loader")
            {
                return new Loader(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Bus")
            {
                return new Bus(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Trolleybus")
            {
                return new Trolleybus(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Tram")
            {
                return new Tram(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Motorcycle")
            {
                return new Motorcycle(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "HorseDrawnCarriage")
            {
                return new HorseDrawnCarriage(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Bicycle")
            {
                return new Bicycle(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            if (type == "Tank")
            {
                return new Tank(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
            }

            return new Ufo(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
        }
    }
}
