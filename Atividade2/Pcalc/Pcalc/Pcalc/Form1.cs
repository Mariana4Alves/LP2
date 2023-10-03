using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNumero2_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("numero 2 inválido");
                txtNumero2.Focus();
            }
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            resultado = numero2 + numero1;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnSubtrai_Click(object sender, EventArgs e)
        {
            resultado = numero2 - numero1;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnMultiplica_Click(object sender, EventArgs e)
        {
            resultado = numero2 * numero1;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if(numero2 == 0)
            {
                MessageBox.Show("Não pode dividir por zero!", "Errrou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero2.Focus();
            }
            else
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString();
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo sair?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void TxtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("numero 1 inválido");
                txtNumero1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Clear();
            txtResultado.Clear();

            txtNumero1.Focus();
            resultado = 0;
            numero1 = 0;
            numero2 = 0;
        }
    }
}
