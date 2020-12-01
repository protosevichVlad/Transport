using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Model
{
    class Car: Vehicle
    {
        public Car(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapasity, int maxSpeed, int startSpead)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapasity = fuelTankCapasity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpead;

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

            Refuel(fuelTankCapasity);
        }
    }
}
