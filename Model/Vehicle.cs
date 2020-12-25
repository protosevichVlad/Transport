using System;
using System.Collections.Generic;

namespace Model
{
    public class Vehicle
    {
        public string VehicleBrand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public Fuel Fuel { get; set; } 
        public int QuantityOfDoors { get; set; } = 0;
        public int QuantityOfOpenedDoors { get; set; } = 0;
        public int QuantityOfWheels { get; set; } = 0;
        public int QuantityOfPassengers { get; set; } = 0;
        public int Payload { get; set; } = 0;
        public double MaxSpeed { get; set; } = 0;
        public double StartSpeed { get; set; } = 0;
        public double CurrentSpeed { get; set; } = 0;
        public int FuelTankCapacity { get; set; } = 0;
        public double CurrentFuelLevel { get; set; } = 0;
        public double FuelConsumption { get; set; } = 0;
        public string Propeller { get; set; } = "physical";
        public string Purpose { get; set; } = ""; //  public / passenger / cargo
        public bool Signalings { get; set; } = false;
        public bool BrakingSystem { get; set; } = false;
        public bool Headlights { get; set; } = false;
        public bool Trailer { get; set; } = false;
        public bool InMotion { get; set; } = false;
        public List<string> LogString { get; private set; } = new List<string>();
        public double PassedWay { get; set; } = 0;
        public double Acceleration { get; set; } = 0;
        public DateTime Time { get; set; }
        public double CurrentSpeedKmInH
        {
            get
            {
                return CurrentSpeed * 3.6;
            }

            set
            {
                CurrentSpeed = value / 3.6;
            }
        }

        private void ShowMessage(string message)
        {
            string logString = $"{Time.ToString("HH:mm:ss")} # {VehicleBrand} {Model} - {message}";
            Console.WriteLine(logString);
            LogString.Add(logString);
        }
        
        public void OpenDoor()
        {
            if (QuantityOfDoors > 0)
            {
                if (QuantityOfOpenedDoors < QuantityOfDoors)
                {
                    ShowMessage("The door is open.");
                    QuantityOfOpenedDoors++;
                }
                else
                {
                    ShowMessage("All doors are open.");
                }
            }
            else
            {
                ShowMessage("Doors are missing.");
            }
        }

        public void CloseDoor()
        {
            if (QuantityOfDoors > 0)
            {
                if (QuantityOfOpenedDoors > 0)
                {
                    ShowMessage("The door is closed.");
                    QuantityOfOpenedDoors--;
                }
                else
                {
                    ShowMessage("All doors are closed.");
                }
            }
            else
            {
                ShowMessage("Doors are missing.");
            }
        }

        public void Launch()
        {
            if (!InMotion)
            {
                if (CurrentFuelLevel > 0)
                {
                    ShowMessage("The movement started.");
                    CurrentSpeed = StartSpeed;
                    InMotion = true;
                    Acceleration = (MaxSpeed * MaxSpeed - StartSpeed * StartSpeed) / (FuelTankCapacity / FuelConsumption * 100000.0);
                }
                else
                {
                    ShowMessage("No fuel no movement possible.");
                    InMotion = false;
                }
            }
            else
            {
                ShowMessage("The vehicle is already moving.");
            }
        }

        public void Stop()
        {
            if (InMotion)
            {
                ShowMessage("The vehicle is stopped");
                CurrentSpeed = 0;
                InMotion = false;
            }
            else
            {
                ShowMessage("The vehicle has already been stopped.");
            }
        }

        public void ChangeTheSpeedTo(double deltaSpeed)
        {
            if (CurrentSpeed == 0 && deltaSpeed > 0)
            {
                Launch();
            }

            if (CurrentSpeed + deltaSpeed <= MaxSpeed && CurrentSpeed + deltaSpeed >= 0)
            {
                CurrentSpeed += deltaSpeed;
                ShowMessage($"The current speed has changed to {deltaSpeed}. Current speed is now {CurrentSpeed}");
            }
            else if (CurrentSpeed + deltaSpeed > MaxSpeed) 
            {
                CurrentSpeed = MaxSpeed;
                ShowMessage($"The current speed has changed to {MaxSpeed - CurrentSpeed}. Current speed is now {MaxSpeed}");
            }
            else if (CurrentSpeed - deltaSpeed < 0)
            {
                CurrentSpeed = 0;
                ShowMessage($"The current speed has changed to {CurrentSpeed}. Current speed is now 0");
            }
            else if (CurrentSpeed == MaxSpeed)
            {
                ShowMessage("The vehicle is moving at maximum speed.");
            }
            else if (CurrentSpeed == 0)
            {
                ShowMessage("The vehicle cannot slow down because it is stopped");
            }
        }

        public void Refuel(int quantityFuel)
        {
            if (CurrentFuelLevel + quantityFuel <= FuelTankCapacity)
            {
                CurrentFuelLevel += quantityFuel;
                ShowMessage($"The vehicle is filled with {quantityFuel} liters. The tank is {CurrentFuelLevel} liters full");
            }
            else
            {
                ShowMessage($"The tank is full.");
                CurrentFuelLevel = FuelTankCapacity;
            }
        }

        public void Shift(double time)
        {
            Time = Time.AddSeconds((int)time);

            double oldSpeed = CurrentSpeed;
            ChangeTheSpeedTo(Acceleration * time);

            double deltaWay = (int)((oldSpeed * time) + (CurrentSpeed * time / 2)) / 1000.0;

            if (Math.Floor(PassedWay / 50.0) < Math.Floor((PassedWay + deltaWay) / 50.0))
            {
                ShowMessage($"\tCurrentSpeed: {CurrentSpeed};\tPassedWay: {PassedWay}; \t FuelLevel: {CurrentFuelLevel}");
            }

            PassedWay += deltaWay;
            CurrentFuelLevel -= FuelConsumption  / 100.0 * deltaWay;

            if (CurrentFuelLevel < 0)
            {
                CurrentFuelLevel = 0;
            }
        }
    }
}
