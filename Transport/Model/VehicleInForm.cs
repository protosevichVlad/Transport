using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport.Model
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
            InformationOnForm.FuelLevel.Maximum = Vehicle.FuelTankCapasity;
            InformationOnForm.FuelLevel.Value = Vehicle.FuelTankCapasity;
        }

        public void Launch()
        {
            launchThread = new Thread(new ThreadStart(LaunchThread));
            launchThread.Start(); // запускаем поток
        }

        public void Stop()
        {
            Vehicle.Stop();
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
            return (Image)Properties.Resources.UFO;
        }
    }
}
