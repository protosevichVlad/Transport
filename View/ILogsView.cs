using System.Collections.Generic;

namespace View
{
    public interface ILogsView : IView
    {
        void ShowLogs(List<string> logs);
    }
}
