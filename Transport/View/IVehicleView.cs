using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Model;


namespace Transport.View
{
    interface IVehicleView
    {
        string GetBrandVehicle();
        string GetModelVehicle();
        string GetTypeVehicle();
        string GetFuelNameVehicle();
        double GetFuelConsumptionVehicle();
        int GetFuelTankCapasityVehicle();
        int GetMaxSpeedVehicle();
        int GetStartSpeedVehicle();

        void SetFuel(List<Model.Fuel> fuels);
        void NextPage(int index);
        void CloseForm();
        
    }
}
