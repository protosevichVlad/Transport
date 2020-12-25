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
        int GetFuelTankCapacityVehicle();
        int GetMaxSpeedVehicle();
        int GetStartSpeedVehicle();

        void SetFuel(List<string> fuels);
        void NextPage(int index);
    }
}
