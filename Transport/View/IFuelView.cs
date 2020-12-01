using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.View
{
    interface IFuelView
    {
        List<string> GetListFuelNames();
        void CloseForm();
        void SetFuels(List<string> fuelNames);
    }
}
