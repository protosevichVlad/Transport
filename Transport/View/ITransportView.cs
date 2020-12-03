using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport.View
{
    interface ITransportView
    {
        void Start();
        void Stop();
        void CreateVihecle();
        void CreateFuels();
        void ShowAllVehicles();
        List<PictureBox> GetPickureBoxWithVeclise();
        List<Label> GetLabels();
        List<ProgressBar> GetProgressBars();
    }
}
