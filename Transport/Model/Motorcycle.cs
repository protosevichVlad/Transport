using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Model
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapasity, double maxSpeed, double startSpead)
    {
        VehicleBrand = vehicleBrand;
        Model = model;
        Fuel = fuel;
        FuelConsumption = fuelConsumption;
        FuelTankCapasity = fuelTankCapasity;
        MaxSpeed = maxSpeed;
        StartSpeed = startSpead;

        Type = "Motorcycle";
        QuantityOfWheels = 2;
        QuantityOfPassengers = 2;
        Payload = 200;
        Propeller = "Internal combustion engine";
        Purpose = "Personal";
        Signalings = true;
        BrakingSystem = true;
        Headlights = true;

        Refuel(fuelTankCapasity);
    }
}
}
