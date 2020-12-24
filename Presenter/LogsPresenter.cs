using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Presenter
{
    public class LogsPresenter
    {
        private ILogsView _view;

        public LogsPresenter(ILogsView view)
        {
            _view = view;
        }

        public void ShowLogs(List<string> logs)
        {
            _view.ShowLogs(logs);
        }
    }
}
