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
using Transport.Model;
using Transport.Presenter;

namespace Transport
{
    public partial class Vehicle : Form, IVehicleView
    {
        private VehiclePresentor _presentor;
        public Vehicle()
        {
            InitializeComponent();
            _presentor = new VehiclePresentor(this);
        }

        public void CloseForm()
        {
            this.Close();
        }

        public string GetBrandVehicle()
        {
            return textBoxBrand.Text;
        }

        public string GetTypeVehicle()
        {
            return comboBoxType.SelectedItem.ToString();
        }

        public double GetFuelConsumptionVehicle()
        {
            return (double)numericUpDownFuelConsumption.Value;
        }

        public string GetFuelNameVehicle()
        {
            return comboBoxFuelType.SelectedItem.ToString();
        }

        public int GetFuelTankCapasityVehicle()
        {
            return (int)numericUpDownFuelTankCapacity.Value;
        }

        public int GetMaxSpeedVehicle()
        {
            return (int)numericUpDownMaxSpeed.Value;
        }

        public string GetModelVehicle()
        {
            return textBoxModel.Text;
        }

        public int GetStartSpeedVehicle()
        {
            return (int)numericUpDownStartingSpeed.Value;
        }

        public void NextPage(int index)
        {
            textBoxBrand.Text = string.Empty;
            textBoxModel.Text = string.Empty;
            comboBoxFuelType.ResetText();
            comboBoxType.ResetText();
            numericUpDownFuelConsumption.Value = 0;
            numericUpDownFuelTankCapacity.Value = 0;
            numericUpDownMaxSpeed.Value = 0;
            numericUpDownStartingSpeed.Value = 0;
        }

        public void SetFuel(List<Model.Fuel> fuels)
        {
            string[] stringFuel = new string[fuels.Count];
            for (int i = 0; i < fuels.Count; i++)
            {
                stringFuel[i] = fuels[i].Name;
            }

            comboBoxFuelType.Items.AddRange(stringFuel);
        }
    }
}
