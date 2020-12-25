using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public interface ITransportView: IView
    {
        void Start();
        void Stop();
        void CreateVehicle();
        void CreateFuels();
        void ShowAllVehicles();
        List<PictureBox> GetPictureBoxWithVehicle();
        List<Label> GetLabels();
        List<ProgressBar> GetProgressBars();
    }
}
