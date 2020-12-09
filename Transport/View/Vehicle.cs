using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Presenter;
using View;

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
            return comboBoxType.Text;
        }

        public double GetFuelConsumptionVehicle()
        {
            return (double)numericUpDownFuelConsumption.Value;
        }

        public string GetFuelNameVehicle()
        {
            return comboBoxFuelType.Text;
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
            return (int) numericUpDownStartingSpeed.Value;
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

            titleLabel.Text = $"You entered data about {index} out of 5 vehicles";
        }

        public void SetFuel(List<string> fuels)
        {
            comboBoxFuelType.Items.AddRange(fuels.ToArray());
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _presentor.Submit();
            }
        }

        private void textBoxBrand_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBrand.Text))
            {
                e.Cancel = true;
                textBoxBrand.Focus();
                appErrorProvider.SetError(textBoxBrand, "Field brand empty!");
            }
            else
            {
                e.Cancel = false;
                appErrorProvider.SetError(textBoxBrand, "");
            }
        }

        private void textBoxModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModel.Text))
            {
                e.Cancel = true;
                textBoxModel.Focus();
                appErrorProvider.SetError(textBoxModel, "Field model empty!");
            }
            else
            {
                e.Cancel = false;
                appErrorProvider.SetError(textBoxModel, "");
            }
        }

        private void numericUpDownStartingSpeed_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDownMaxSpeed.Value < numericUpDownStartingSpeed.Value)
            {
                e.Cancel = true;
                numericUpDownStartingSpeed.Focus();
                appErrorProvider.SetError(numericUpDownStartingSpeed, "Maximum speed less starting speed");
            }
            else
            {
                e.Cancel = false;
                appErrorProvider.SetError(numericUpDownStartingSpeed, "");
            }
        }

        private void comboBoxFuelType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxFuelType.Text))
            {
                e.Cancel = true;
                comboBoxFuelType.Focus();
                appErrorProvider.SetError(comboBoxFuelType, "Select the fuel type");
            }
            else
            {
                e.Cancel = false;
                appErrorProvider.SetError(comboBoxFuelType, "");
            }
        }
    }
}
