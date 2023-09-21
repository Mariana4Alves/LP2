using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IMCCalc : Form
    {
        public IMCCalc()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(MskTxtAlt.Text);
            double peso = Convert.ToDouble(MskTxtPeso.Text);

            double imc = CalcularIMC(altura, peso);
            string classificacao = ClassificarIMC(imc);

            LblResult.Text = $"{imc:F2}";
            LblClass.Text = $"{classificacao}";
        }

        private double CalcularIMC(double altura, double peso)
        {
            return peso / (altura * altura);
        }

        private string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 24.9)
            {
                return "Peso normal";
            }
            else if (imc < 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc < 34.9)
            {
                return "Obesidade Grau I";
            }
            else if (imc < 39.9)
            {
                return "Obesidade Grau II";
            }
            else
            {
                return "Obesidade Grau III";
            }
        }
    }
}
