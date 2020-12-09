using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View;
using Presenter;

namespace Transport
{
    public partial class Fuel : Form, IFuelView
    {
        private FuelPresenter _presenter;
        public Fuel()
        {
            InitializeComponent();
            _presenter = new FuelPresenter(this);
            _presenter.SetStartFuel();
        }

        public List<string> GetListFuelNames()
        {
            List<string> fuels = new List<string>();
            if (checkBoxDiesel.Checked)
            {
                fuels.Add(checkBoxDiesel.Text);
            }

            if (checkBoxPetrol.Checked)
            {
                fuels.Add(checkBoxPetrol.Text);
            }

            if (checkBoxGas.Checked)
            {
                fuels.Add(checkBoxGas.Text);
            }

            if (checkBoxElectricity.Checked)
            {
                fuels.Add(checkBoxElectricity.Text);
            }

            if (checkBoxPhysicalForce.Checked)
            {
                fuels.Add(checkBoxPhysicalForce.Text);
            }

            return fuels;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            _presenter.Submit();
        }

        public void CloseForm()
        {
            this.Close();
        }
        
        public void SetFuels(List<string> fuelNames)
        {
            if (fuelNames.IndexOf("Diesel fuel") != -1)
            {
                checkBoxDiesel.Checked = true;
            }

            if (fuelNames.IndexOf("Petrol") != -1)
            {
                checkBoxPetrol.Checked = true;
            }

            if (fuelNames.IndexOf("Gas") != -1)
            {
                checkBoxGas.Checked = true;
            }

            if (fuelNames.IndexOf("Electricity") != -1)
            {
                checkBoxElectricity.Checked = true;
            }

            if (fuelNames.IndexOf("Physical force") != -1)
            {
                checkBoxPhysicalForce.Checked = true;
            }
        }
    }
}
