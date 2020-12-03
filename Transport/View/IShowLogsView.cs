using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.View
{
    interface IShowLogsView
    {
        void SetVehicles(List<string> names);
        List<string> GetExportTypes();
        int GetIndexVehicles();
    }
}
