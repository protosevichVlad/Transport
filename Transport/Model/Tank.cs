using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Model
{
    class Tank: Vehicle
    {
        public Tank(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapasity, double maxSpeed, double startSpead)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapasity = fuelTankCapasity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpead;

            Type = "Tank";
            QuantityOfDoors = 3;
            QuantityOfWheels = 2;
            QuantityOfPassengers = 3;
            Payload = 1000;
            Propeller = "Internal combustion engine";
            Purpose = "Military";
            Headlights = true;

            Refuel(fuelTankCapasity);
        }
    }
}
