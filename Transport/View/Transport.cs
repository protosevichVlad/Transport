using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View;
using Presenter;

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
            Fuel fuel = new Fuel();
            fuel.ShowDialog();
        }

        private void createVechiclesButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.FormClosed += _presenter.ShowVehicles;
            vehicle.ShowDialog();
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

        public List<Label> GetLabels()
        {
            List<Label> labels = new List<Label>();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);
            labels.Add(label14);
            labels.Add(label15);
            labels.Add(label16);
            labels.Add(label17);
            labels.Add(label18);
            labels.Add(label19);
            labels.Add(label20);
           
            return labels;
        }

        public List<ProgressBar> GetProgressBars()
        {
            List<ProgressBar> progressBars = new List<ProgressBar>();
            progressBars.Add(progressBar1);
            progressBars.Add(progressBar2);
            progressBars.Add(progressBar3);
            progressBars.Add(progressBar4);
            progressBars.Add(progressBar5);

            return progressBars;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _presenter.Stop();
        }
    }
}
