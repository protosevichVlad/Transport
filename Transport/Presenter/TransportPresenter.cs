using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.View;
using Transport.Model;

namespace Transport.Presenter
{
    class TransportPresenter
    {
        private ITransportView _view;

        public TransportPresenter(ITransportView view)
        {
            _view = view;
        }

        public void OpenFormWithCreatingFuel()
        {
            Fuel fuel = new Fuel();
            fuel.ShowDialog();
        }

        public void OpenFormWithCreatingVehicles()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.FormClosed += ShowVehicles;
            vehicle.ShowDialog();
        }

        public void ShowVehicles(object sender, EventArgs e)
        {
            List<VehicleInForm> vehicleInForms = new List<VehicleInForm>();
            var vehicles = ApplicationContext.Vehicles;
            var pictureBoxes = _view.GetPickureBoxWithVeclise();
            vehicleInForms.Add(new VehicleInForm(vehicles[0], pictureBoxes[0]));
            vehicleInForms.Add(new VehicleInForm(vehicles[1], pictureBoxes[1]));
            vehicleInForms.Add(new VehicleInForm(vehicles[2], pictureBoxes[2]));
            vehicleInForms.Add(new VehicleInForm(vehicles[3], pictureBoxes[3]));
            vehicleInForms.Add(new VehicleInForm(vehicles[4], pictureBoxes[4]));

            ApplicationContext.VehicleInForms = vehicleInForms;
        }

        public void Start()
        {
            ApplicationContext.VehicleInForms.ForEach(v => v.Launch());
        }
    }
}
