using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using Presenter;

namespace Transport.View
{
    public partial class Logs : Form , ILogsView
    {
        public LogsPresenter _presentor;
        public Logs()
        {
            InitializeComponent();
            _presentor = new LogsPresenter(this);
        }

        public Logs(List<string> logs)
        {
            InitializeComponent();
            _presentor = new LogsPresenter(this);
            ShowLogs(logs);
        }

        public void ShowLogs(List<string> logs)
        {
            LogsRichTextBox.Text = String.Join("\n", logs);
        }
    }
}
