using System.Collections.Generic;
using View;
using Model;

namespace Presenter
{
    public class ShowLogsPresenter
    {
        private IShowLogsView _view;
        public ShowLogsPresenter(IShowLogsView view)
        {
            _view = view;
            List<string> names = new List<string>();
            foreach (var vehicle in ApplicationContext.Vehicles)
            {
                names.Add($"{vehicle.VehicleBrand} {vehicle.Model}");
            }

            _view.SetVehicles(names);
        }

        public void Submit()
        {
            var index = _view.GetIndexVehicles();
            if (index == -1)
            {
                return;
            }

            var vehicle = ApplicationContext.Vehicles[index];
            System.IO.File.WriteAllLines($@".\Log_{vehicle.VehicleBrand}_{vehicle.Model}.txt",
                vehicle.LogString.ToArray());
        }

    }
}
