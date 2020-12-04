using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Model
{
    class Bus : Vehicle
    {
        public Bus(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapasity, double maxSpeed, double startSpead)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapasity = fuelTankCapasity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpead;

            Type = "Bus";
            QuantityOfDoors = 3;
            QuantityOfWheels = 4;
            QuantityOfPassengers = 25;
            Payload = 2000;
            Propeller = "Internal combustion engine";
            Purpose = "Public";
            Signalings = true;
            BrakingSystem = true;
            Headlights = true;
            Trailer = true;

            Refuel(fuelTankCapasity);
        }
    }
}
