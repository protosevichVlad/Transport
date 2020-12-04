using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Model
{
    class HorseDrawnCarriage
        : Vehicle
    {
        public HorseDrawnCarriage(string vehicleBrand, string model, Fuel fuel, double fuelConsumption,
                   int fuelTankCapasity, double maxSpeed, double startSpead)
        {
            VehicleBrand = vehicleBrand;
            Model = model;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            FuelTankCapasity = fuelTankCapasity;
            MaxSpeed = maxSpeed;
            StartSpeed = startSpead;

            Type = "HorseDrawnCarriage";
            QuantityOfWheels = 4;
            QuantityOfPassengers = 5;
            Payload = 300;
            Propeller = "Horse";
            Purpose = "Personal";

            Refuel(fuelTankCapasity);
        }
    }
}
