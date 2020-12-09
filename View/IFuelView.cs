using System.Collections.Generic;

namespace View
{
    public interface IFuelView
    {
        List<string> GetListFuelNames();
        void CloseForm();
        void SetFuels(List<string> fuelNames);
    }
}
