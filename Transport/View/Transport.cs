using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport.View;
using Transport.Presenter;

namespace Transport
{
    public partial class Transport : Form, ITransportView
    {
        private TransportPresenter _presenter;
        public Transport()
        {
            InitializeComponent();
            _presenter = new TransportPresenter(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowLogs showLogs = new ShowLogs();
            showLogs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void CreateVihecle()
        {
            throw new NotImplementedException();
        }

        public void CreateFuels()
        {
            
        }

        public void ShowAllVehicles()
        {
            throw new NotImplementedException();
        }

        private void createFuelButton_Click(object sender, EventArgs e)
        {
            _presenter.OpenFormWithCreatingFuel();
        }

        private void createVechiclesButton_Click(object sender, EventArgs e)
        {
            _presenter.OpenFormWithCreatingVehicles();
        }

        public List<PictureBox> GetPickureBoxWithVeclise()
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7);
            pictureBoxes.Add(pictureBox8);
            pictureBoxes.Add(pictureBox9);
            pictureBoxes.Add(pictureBox10);

            return pictureBoxes;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _presenter.Start();
        }
    }
}
