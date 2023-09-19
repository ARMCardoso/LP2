using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE3
{
    public partial class Form1 : Form
    {
        double altura, peso, IMC;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MskPeso_Validated(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(mskPeso, "");
            if (!double.TryParse(mskPeso.Text, out peso) || (peso <= 0)){

                MessageBox.Show("Peso Inválido!");
                errorProvider1.SetError(mskPeso, "Peso Inválido!");

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            mskAltura.Text = "";
            mskPeso.Text = "";
            txtIMC.Text = "";
        }

        private void MskAltura_Validated(object sender, EventArgs e)
        {
            
            errorProvider2.SetError(mskAltura, "");
            if (!double.TryParse(mskAltura.Text, out altura) || (altura <= 0))
            {

                MessageBox.Show("Altura Inválida!");
                errorProvider2.SetError(mskAltura, "Altura Inválida!");

            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            IMC = peso / Math.Pow(2, altura);
            IMC = Math.Round(IMC, 1);
            txtIMC.Text = IMC.ToString("N1");

            if (IMC < 18.5)
                MessageBox.Show("MAGREZA");
                else
                    if(IMC<=24.9)
                        MessageBox.Show("NORMAL");
                        else
                        if(IMC<=29.9)
                            MessageBox.Show("SOBREPESO");
                            else
                            if (IMC <= 39.9)
                                MessageBox.Show("OBESIDADE");
                                else
                                    MessageBox.Show("OBESIDADE GRAVE");
        }
    }
}
