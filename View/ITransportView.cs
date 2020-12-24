using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public interface ITransportView: IView
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
