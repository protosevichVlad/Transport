using System.Collections.Generic;

namespace View
{
    public interface IShowLogsView: IView
    {
        void SetVehicles(List<string> names);
        List<string> GetExportTypes();
        int GetIndexVehicles();
        void OpenLog(List<string> logs);
    }
}
