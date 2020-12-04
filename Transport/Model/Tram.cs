using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Model
{
    class Tram : Vehicle
    {
        public Tram(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapasity, double maxSpeed, double startSpead)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapasity = fuelTankCapasity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpead;

            Type = "Tram";
            QuantityOfDoors = 3;
            QuantityOfWheels = 4;
            QuantityOfPassengers = 25;
            Payload = 2000;
            Propeller = "Electromotor";
            Purpose = "Public";
            Signalings = true;
            BrakingSystem = true;
            Headlights = true;
            Trailer = true;

            Refuel(fuelTankCapasity);
        }
    }
}
