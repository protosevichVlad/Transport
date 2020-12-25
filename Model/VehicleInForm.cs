using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class VehicleInForm
    {
        public Vehicle Vehicle { get; set; }
        public PictureBox PictureBox { get; set; }
        public InformationOnForm InformationOnForm { get; set; }

        private Thread launchThread;

        public VehicleInForm(Vehicle vehicle, PictureBox pictureBox, InformationOnForm informationOnForm)
        {
            Vehicle = vehicle;
            PictureBox = pictureBox;
            InformationOnForm = informationOnForm;


            pictureBox.Image = GetImage();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Visible = true;

            InformationOnForm.BrandAndModel.Text = $"{Vehicle.VehicleBrand} {Vehicle.Model}";
            InformationOnForm.Time.Text = $"0 s";
            InformationOnForm.Speed.Text = "- km/h";
            InformationOnForm.PassedWay.Text = "- km";
            InformationOnForm.FuelLevel.Maximum = Vehicle.FuelTankCapacity;
            InformationOnForm.FuelLevel.Value = Vehicle.FuelTankCapacity;
        }

        public void Launch()
        {
            launchThread = new Thread(new ThreadStart(LaunchThread));
            launchThread.Start(); // запускаем поток
        }

        public void Stop()
        {
            Vehicle.Stop();
            InformationOnForm.Speed.Text = $"{Vehicle.CurrentSpeedKmInH:0.0} km/h";
            launchThread.Abort();
            launchThread.Join();
        }

        private void LaunchThread()
        {
            Vehicle.Launch();
            while (Vehicle.CurrentFuelLevel > 0)
            {
                PictureBox.Invoke((MethodInvoker)delegate
                {
                    Vehicle.Shift(50.0);
                    PictureBox.Left = 10 + (int)((Vehicle.PassedWay / 500.0) *  900.0);

                    InformationOnForm.Time.Text = $"{Vehicle.Time.ToString("HH:mm:ss")}";
                    InformationOnForm.Speed.Text = $"{Vehicle.CurrentSpeedKmInH:0.0} km/h";
                    InformationOnForm.PassedWay.Text = $"{Vehicle.PassedWay:0.00} km";
                    InformationOnForm.FuelLevel.Value = (int)Vehicle.CurrentFuelLevel;

                });
                Thread.Sleep(200);
            }
        }

        private Image GetImage()
        {
            if (Vehicle.Type == "Car")
            {
                return (Image)Properties.Resources.Car;
            }
            else if (Vehicle.Type == "Scooter")
            {
                return (Image)Properties.Resources.Scooter;
            }
            else if (Vehicle.Type == "Truck")
            {
                return (Image)Properties.Resources.Truck;
            }
            else if (Vehicle.Type == "Loader")
            {
                return (Image)Properties.Resources.Loader;
            }
            else if (Vehicle.Type == "Bus")
            {
                return (Image)Properties.Resources.Bus;
            }
            else if (Vehicle.Type == "Trolleybus")
            {
                return (Image)Properties.Resources.Trolleybus;
            }
            else if (Vehicle.Type == "Tram")
            {
                return (Image)Properties.Resources.Tram;
            }
            else if (Vehicle.Type == "Motorcycle")
            {
                return (Image)Properties.Resources.Motorcycle;
            }
            else if (Vehicle.Type == "HorseDrawnCarriage")
            {
                return (Image)Properties.Resources.HorseDrawnCarriage;
            }
            else if (Vehicle.Type == "Bicycle")
            {
                return (Image)Properties.Resources.Bicycle;
            }
            else if (Vehicle.Type == "Tank")
            {
                return (Image)Properties.Resources.Tank;
            }

            return (Image)Properties.Resources.UFO;
        }
    }
}
