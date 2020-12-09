using System.Collections.Generic;

namespace View
{
    public interface IShowLogsView
    {
        void SetVehicles(List<string> names);
        List<string> GetExportTypes();
        int GetIndexVehicles();
    }
}
