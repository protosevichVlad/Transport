using System.Collections.Generic;

namespace View
{
    public interface IVehicleView: IView
    {
        string GetBrandVehicle();
        string GetModelVehicle();
        string GetTypeVehicle();
        string GetFuelNameVehicle();
        double GetFuelConsumptionVehicle();
        int GetFuelTankCapasityVehicle();
        int GetMaxSpeedVehicle();
        int GetStartSpeedVehicle();

        void SetFuel(List<string> fuels);
        void NextPage(int index);
    }
}
