using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            double valorA, valorB, valorC;

            if(!double.TryParse(txtA.Text, out valorA) || !double.TryParse(txtB.Text, out valorB) || !double.TryParse(txtC.Text, out valorC))
                MessageBox.Show("Valores devem ser numéricos");
            else
            {
                if(valorA < (valorB + valorC) && valorA > 
                    Math.Abs(valorB - valorC) && valorB < (valorA + valorC) 
                    && valorB > Math.Abs(valorA - valorC)
                    && valorC < (valorA + valorB) && 
                    valorC > Math.Abs(valorA - valorB))
                {
                    if(valorA == valorB && valorB == valorC)
                        MessageBox.Show($"Os valores {valorA}, {valorB} e {valorC} formam um triângulo equilátero.");
                    else
                    {
                        if(valorA == valorB || valorA == valorC || valorB == valorC)
                        {
                            MessageBox.Show($"Os valores {valorA}, {valorB} e {valorC} formam um triângulo isósceles.");
                        }
                        else
                        {
                            MessageBox.Show($"Os valores {valorA}, {valorB} e {valorC} formam um triângulo escaleno.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Os valores {valorA}, {valorB} e {valorC} não formam um triângulo.");
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            errorProvider1.SetError(txtA, "");
            errorProvider2.SetError(txtB, "");
            errorProvider3.SetError(txtC, "");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtbA_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtA, "");
            double valorA;

            if(!double.TryParse(txtA.Text, out valorA))
            {
                errorProvider1.SetError(txtA, "Valor de A inválido.");
            }
        }

        private void TxtbB_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(txtB, "");
            double valorB;

            if (!double.TryParse(txtA.Text, out valorB))
            {
                errorProvider2.SetError(txtB, "Valor de B inválido.");
            }

        }

        private void TxtbC_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(txtC, "");
            double valorC;

            if (!double.TryParse(txtA.Text, out valorC))
            {
                errorProvider3.SetError(txtC, "Valor de C inválido.");
            }

        }
    }
}
