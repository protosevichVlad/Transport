using System.Collections.Generic;
using View;
using Model;

namespace Presenter
{
    public class FuelPresenter
    {
        private IFuelView _view;

        public FuelPresenter(IFuelView view)
        {
            _view = view;
        }

        public void Submit()
        {
            List<string> fuelNames = _view.GetListFuelNames();
            List<global::Model.Fuel> fuels = new List<global::Model.Fuel>();
            foreach (string name in fuelNames)
            {
                fuels.Add(new global::Model.Fuel { Name = name });
            }

            ApplicationContext.Fuels = fuels;

            _view.Close();
        }

        public void SetStartFuel()
        {
            List<global::Model.Fuel> fuels = ApplicationContext.Fuels;
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
