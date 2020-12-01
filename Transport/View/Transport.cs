using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport
{
    public partial class Transport : Form
    {
        public Transport()
        {
            InitializeComponent();
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
            Fuel fuel = new Fuel();
            fuel.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowLogs showLogs = new ShowLogs();
            showLogs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.ShowDialog();
        }
    }
}
