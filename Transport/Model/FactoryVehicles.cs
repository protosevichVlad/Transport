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

            return new Ufo(vehicleBrand, model, fuel, fuelConsumption, fuelTankCapasity, maxSpeed, startSpead);
        }
    }
}
