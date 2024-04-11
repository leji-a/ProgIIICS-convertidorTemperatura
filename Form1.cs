using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            if (txtCelsius.Text.Trim() != "")
            {
                double tempC = 0;
                if (double.TryParse(txtCelsius.Text.Trim(), out tempC)){
                    MessageBox.Show(txtCelsius.Text.Trim() + " ° en Celsius es igual a " + 
                        convertidorTemperatura.CelsiusAFahrenheit(tempC) + " ° en Fahrenheit");
                } else
                {
                    MessageBox.Show("Debe ingresar un numero double.");
                }
            } else
            {
                MessageBox.Show("Ingrese una temperatura.");
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            if (txtFahrenheit.Text.Trim() != "")
            {
                double tempF = 0;
                if (double.TryParse(txtFahrenheit.Text.Trim(), out tempF))
                {
                    MessageBox.Show(txtFahrenheit.Text.Trim() + " ° en Fahrenheit es igual a " +
                        convertidorTemperatura.FahrenheitACelsius(tempF) + " ° en Celsius");
                } else
                {
                    MessageBox.Show("Debe ingresar un numero double.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una temperatura");
            }
        }
    }
}
