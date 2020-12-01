using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Model;
using Transport.View;

namespace Transport.Presenter
{
    class VehiclePresentor
    {
        private IVehicleView _view;

        public VehiclePresentor(IVehicleView view)
        {
            _view = view;
            _view.SetFuel(ApplicationContext.Fuels);
        }

        public void Submit()
        {
            
        }
    }
}
