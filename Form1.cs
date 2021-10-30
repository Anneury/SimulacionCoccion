using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionCoccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Simular()
        {
            int TipoCarne, TipoCombustible;

            TipoCarne = CarneComboBox.SelectedIndex;
            TipoCombustible = CombustibleComboBox.SelectedIndex;


            if (TipoCombustible == 0)
            {
                if (TipoCarne == 0)
                {
                    TiempoCoccionTextBox.Text = "50min";
                    CarneCocinadaTextBox.Text = "1kg";
                }

                if (TipoCarne == 1)
                {
                    TiempoCoccionTextBox.Text = "60min";
                    CarneCocinadaTextBox.Text = "1kg";
                }
            }
            if (TipoCombustible == 1)
            {
                if (TipoCarne == 0)
                {
                    TiempoCoccionTextBox.Text = "75min";
                    CarneCocinadaTextBox.Text = "1kg";
                }

                if (TipoCarne == 1)
                {
                    TiempoCoccionTextBox.Text = "85min";
                    CarneCocinadaTextBox.Text = "1kg";
                }
            }
            if (TipoCombustible == 2)
            {
                if (TipoCarne == 0)
                {
                    TiempoCoccionTextBox.Text = "30min";
                    CarneCocinadaTextBox.Text = "1kg";
                }

                if (TipoCarne == 1)
                {
                    if (radioButton1.Checked)
                    {
                        TiempoCoccionTextBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        TiempoCoccionTextBox.Text = "70min";
                    }
                    if (radioButton3.Checked)
                    {
                        TiempoCoccionTextBox.Text = "53min";
                    }
                    if (radioButton4.Checked)
                    {
                        TiempoCoccionTextBox.Text = "50min";
                    }
                    if (radioButton5.Checked)
                    {
                        TiempoCoccionTextBox.Text = "40min";
                    }
                    CarneCocinadaTextBox.Text = "1kg";
                }
            }
            if (TipoCombustible == 3)
            {
                if (TipoCarne == 0)
                {
                    TiempoCoccionTextBox.Text = "35min";
                    CarneCocinadaTextBox.Text = "1kg";
                }

                if (TipoCarne == 1)
                {
                    TiempoCoccionTextBox.Text = "45min";
                    CarneCocinadaTextBox.Text = "1kg";
                }
            }
        }

        private void Limpiar()
        {

            TiempoCoccionTextBox.Clear();
            CarneCocinadaTextBox.Clear();
        }

        private void SimularButton_Click(object sender, EventArgs e)
        {
            Simular();
        }

        private void ReiniciarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
