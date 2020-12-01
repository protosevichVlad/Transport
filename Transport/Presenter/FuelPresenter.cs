using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.View;
using Transport.Model;

namespace Transport.Presenter
{
    class FuelPresenter
    {
        private IFuelView _view;

        public FuelPresenter(IFuelView view)
        {
            _view = view;
        }

        public void Submit()
        {
            List<string> fuelNames = _view.GetListFuelNames();
            List<Model.Fuel> fuels = new List<Model.Fuel>();
            foreach (string name in fuelNames)
            {
                fuels.Add(new Model.Fuel { Name = name });
            }

            ApplicationContext.Fuels = fuels;

            _view.CloseForm();
        }

        public void SetStartFuel()
        {
            List<Model.Fuel> fuels = ApplicationContext.Fuels;
            if (fuels is null || fuels.Count == 0)
            {
                return;
            }

            List<string> fuelNames = new List<string>();
            for (int i = 0; i < fuels.Count; i++)
            {
                fuelNames.Add(fuels[i].Name);
            }
            _view.SetFuels(fuelNames);
        }
    }
}
