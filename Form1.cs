using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1
{
    public partial class CALCULO_IMC : Form
    {
        public CALCULO_IMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GO_Click(object sender, EventArgs e)
        {
        double IMC, ALTURA2, PESO2, FINAL2;
            PESO2 - double.Parse(PESO.Text);
            ALTURA2 = double.Parse(ALTURA.Text);
            IMC = PESO2 / (ALTURA2 * ALTURA2);
            FINAL2= IMC * 10000;
            MessageBox.Show("Seu Imc é : " + FINAL2, "Resultado", MessageBoxButtons.OK);
        }
    }
}
