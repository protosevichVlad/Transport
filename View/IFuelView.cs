using System.Collections.Generic;

namespace View
{
    public interface IFuelView: IView
    {
        List<string> GetListFuelNames();
        void SetFuels(List<string> fuelNames);
    }
}
